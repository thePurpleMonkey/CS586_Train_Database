import psycopg2, psycopg2.extras, getpass, urllib.request, sys, json
from bs4 import BeautifulSoup

# Connect to database (VPN must be enabled)
def connect():
	options = {}

	options["dbname"] = options["user"] = "w19wdb19"
	options["password"] = getpass.getpass("Please enter your password: ")

	print("Connecting to database...")
	try:
		conn = psycopg2.connect(host="dbclass.cs.pdx.edu", sslmode="require", **options)
	except psycopg2.OperationalError as e:
		print("Unable to connect to database server. Please check your password and ensure your VPN is enabled and try again.", file=sys.stderr)
		exit(1)

	return conn

def stations(conn):
	print("Downloading station data...")
	data = json.loads(urllib.request.urlopen("https://datahub.ckan.io/dataset/27b40759-d18d-4679-8b31-9b2302abaebf/resource/f76cd172-ad43-447d-b661-6ee15181219b/download/amtrakstations.geojson").read().decode("utf-8"))
	rows = []

	print("Parsing data...")
	for station in data["features"]:
		if station["properties"]["STNTYPE"] != "RAIL":
			continue

		row = {
			"code": station["properties"]["STNCODE"],
			"name": station["properties"]["STNNAME"],
			"address": station["properties"]["ADDRESS1"],
			# TODO: Do something with ADDRESS2 field? Is it ever not empty?
			"city": station["properties"]["CITY"],
			"state": station["properties"]["STATE"],
			"lat": station["geometry"]["coordinates"][1],
			"lon": station["geometry"]["coordinates"][0],
		}
		rows.append(row)

	c = conn.cursor()

	print(f"Uploading {len(rows)} records...")
	psycopg2.extras.execute_batch(c,
		"""
			INSERT INTO train.station VALUES (%(code)s, %(name)s, %(address)s, %(city)s, %(state)s, %(lat)s, %(lon)s)
		""", rows
	)
	conn.commit()
	c.close()
	print("Done.")

def routes(conn):
	print("Downloading partial route data...")
	data = json.loads(urllib.request.urlopen("https://asm.transitdocs.com/api/asm.php").read().decode("utf-8"))
	routes = {}
	stops = []

	print("Processing partial route data...")
	for route in data["trains"]:
		name = route["name"]
		number = int(route["number"])

		if number not in routes:
			routes[number] = name

		stations = []

		# Canadian trains don't report what stations they visit
		if "stations" in route:
			for i, station in enumerate(route["stations"]):
				stops.append({"route": number, "station": station["code"], "order": i})

	route_rows = []
	for number in routes:
		route_rows.append((number, routes[number]))

	c = conn.cursor()
	print(f"Uploading {len(route_rows)} route records and {len(stops)} stop records...")

	# Create tables
	c.execute("""
		CREATE TABLE IF NOT EXISTS train.route (number smallint PRIMARY KEY, name VARCHAR(255) NOT NULL)
	""")
	c.execute("""
		CREATE TABLE IF NOT EXISTS train.stop (
			route smallint REFERENCES train.route,
			station character(3) REFERENCES train.station,
			stop_order smallint NOT NULL,
			scheduled_arrival time(0),
			scheduled_departure time(0),
			PRIMARY KEY (route, station)
		)
	""")

	psycopg2.extras.execute_batch(c,
		"""
			INSERT INTO train.route VALUES (%s, %s) ON CONFLICT DO NOTHING
		""", route_rows
	)
	psycopg2.extras.execute_batch(c,
		"""
			INSERT INTO train.stop VALUES (%(route)s, %(station)s, %(order)s, NULL, NULL) ON CONFLICT DO NOTHING
		""", stops
	)
	conn.commit()
	c.close()
	print("Done.")
	
def amenities(conn):
	c = conn.cursor()

	c.execute("SELECT code FROM train.station")
	stations = [e[0] for e in c.fetchall()]

	for station in stations:
		r = urllib.request.Request(f"http://www.amtrak.com/stations/{station.lower()}.html", 
			headers={'User-Agent': 'Mozilla/5.0', 'Host': 'www.amtrak.com'})
		print("Connecting to", r.full_url)
		response = urllib.request.urlopen(r)
		print("Response:", response.getcode())
		soup = BeautifulSoup(response.read().decode("utf-8"), 'html.parser')
		print(soup.prettify())
		for feature in soup.find(id="stationTab0").find_all("li"):
			print(feature)
		break
	
	c.close()

if __name__ == "__main__":		
	conn = connect()

	#stations(conn)
	routes(conn)
	#amenities(conn)

	conn.close()