using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class _Map {

	[XmlAttribute("mapWidth")]
	public int mapWidth { get; set; }
	[XmlAttribute("mapHeight")]
	public int mapHeight { get; set; }

	[XmlArray("mapTiles")]
	[XmlArrayItem("tile")]
	public _MapTile[] mapTiles { get; set; }

	public _Map() : this(10, 10) {}

	public _Map(int mapWidth, int mapHeight) : this(mapWidth, mapHeight, new _MapTile[mapWidth * mapHeight]) {}

	public _Map(int mapWidth, int mapHeight, _MapTile[] mapTiles)
	{
		if (mapTiles.Length == mapWidth * mapHeight) {
			this.mapWidth = mapWidth;
			this.mapHeight = mapHeight;

			for (int i = 0; i < mapTiles.Length; i++) {
				if (mapTiles [i] == null) {
					mapTiles [i] = new _MapTile ();
				}
			}
			this.mapTiles = mapTiles;
		}
		else {
			Debug.LogError ("Map initialized with incorrect size for given parameters.");
		}
	}
}