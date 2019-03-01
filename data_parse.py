import psycopg2, psycopg2.extras, getpass, urllib.request, sys, json


options = {}

options["dbname"] = options["user"] = "w19wdb19"
options["password"] = getpass.getpass("Please enter your password: ")

print("Downloading data...")
data = json.loads(urllib.request.urlopen("https://datahub.ckan.io/dataset/27b40759-d18d-4679-8b31-9b2302abaebf/resource/f76cd172-ad43-447d-b661-6ee15181219b/download/amtrakstations.geojson").read().decode("utf-8"))
rows = []

print("Parsing data...")
for station in data["features"]:
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

# Connect to database (VPN must be enabled)
print("Connecting to database...")
try:
	conn = psycopg2.connect(host="dbclass.cs.pdx.edu", sslmode="require", **options)
except psycopg2.OperationalError as e:
	print("Unable to connect to database server. Please check your password and ensure your VPN is enabled and try again.", file=sys.stderr)
	exit(1)

c = conn.cursor()

print(f"Uploading {len(rows)} records...")
psycopg2.extras.execute_batch(c,
	"""
		INSERT INTO train.station VALUES (%(code)s, %(name)s, %(address)s, %(city)s, %(state)s, %(lat)s, %(lon)s)
	""", rows
)
conn.commit()
print("Done.")

c.close()
conn.close()