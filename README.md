# ctc21_waste_wizards

This is a project started as part of 
[CTC21: Put Your City on the Map](https://github.com/CodeTheCity/CTC21), 
which ran Saturday 28th Nov 2020 and Sunday 29th Nov 2020.

The aim is to provide Councils and citizens with a shared Open Data source of information about Council-run recycling options in their area.

We are exploring whether using a combination of OpenStreetMap and Wikidata to store and share raw data will leverage existing data standards for codifying locations, materials accepted, materials specifically banned, and opening hours.

We believe that there is a need for a custom UI for editing and display of the data, focussed on the subject. The generic editing facilities of OpenStreetMap and Wikidata could be used by data experts but are too generic for the general public and Councils.

### Useful bits'n'pieces

* A Household Waste and Recycling Centre (HWRC) is a Council-run location with multiple recycling and destined-for-landfill containers that may only be used by residents.
* A Household Recycling Point is a Council-run location, much smaller than a HWRC, with multiple recycling containers that anyone may recycle items. Often an area in a supermarket car park or by a Council building. Also known as a 'bring site'.
* Some Councils also place individual recycling containers, often more like a bin, on street locations. This is prevalent in Aberdeen.
* [Use cases for recycling centre data curation](https://raw.githack.com/CodeTheCity/ctc21_waste_wizards/main/prototype/use_cases.html)
* [Our map of recycling centres in Aberdeen city and shire (with drive time analysis)](https://raw.githack.com/CodeTheCity/ctc21_waste_wizards/main/prototype/index.html)
* [Aberdeen Council Web Site list of HWRCs](https://www.aberdeencity.gov.uk/services/bins-and-recycling/find-your-nearest-recycling-centre)
* [Aberdeen Council Web Site list of Recycling Points](https://www.aberdeencity.gov.uk/services/bins-and-recycling/recycling-points)
* [Our worksheet of waste recycling centres and points in Aberdeen](HWRC.csv)
* [A combined OpenStreetMap + Wikidata data extract](HWRC.geojson) generated using Jez's new [OSM-to-geojson-api](https://github.com/jnicho02/osm-to-geojson-api)
* [Documentation of OpenStreetMap tagging standards for recycling](https://wiki.openstreetmap.org/wiki/Tag:amenity%3Drecycling)
* [Our QuickStatements sheet for adding recycling centres into Wikidata](recycling-centre-quickstatements.csv)
* [Query Wikidata for recycling centres in Scotland](https://w.wiki/occ)
* [Search OpenStreetMap for recycling in Aberdeen](https://www.openstreetmap.org/search?query=aberdeen%20recycling)
* [Query OpenStreetMap using OverPass for recycling sites](https://overpass-turbo.eu/s/10Fv)
* [Query Dsposal for the waste classification of 'mattress'](https://dsposal.uk/search-results/?keyword=Mattress&flexdatalist-keyword=Mattress&list-type=LOW)
* [UK government's classification of waste](https://assets.publishing.service.gov.uk/government/uploads/system/uploads/attachment_data/file/719394/Waste-classification-technical-guidance-WM3.pdf)
