using UnityEngine;
using System.Collections;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class Map : MonoBehaviour {

	private int mapWidth;
	private int mapHeight;
	private GameObject[] map;
	
	private GameObject selectedTile = null;
	
	public Sprite water;
	public Sprite grass;

	enum Tile{
		Water = 0,
		Grass = 1
	}

	void Start () {
		var serializer = new XmlSerializer(typeof(_MapContainer));
		var stream = new FileStream(Path.Combine(Application.dataPath, "Resources/XML/maps/Board_1.xml"), FileMode.Open);
		var mapXml = serializer.Deserialize(stream) as _MapContainer;
		stream.Close();

		mapWidth = mapXml.map.mapWidth;
		mapHeight = mapXml.map.mapHeight;
		map = new GameObject[mapWidth * mapHeight];

		for(int i = 0; i < mapWidth * mapHeight; i++){
			int xPos = i % mapWidth;
			int yPos = i / mapWidth;

			Vector3 position;
			if(yPos % 2 == 0){
				position = new Vector3((3f * xPos) / 2f, yPos * Mathf.Sqrt(3) / 4f, 0);
			}
			else{
				position = new Vector3(0.75f + (3f * xPos) / 2f, yPos * Mathf.Sqrt(3) / 4f, 0);
			}
			Debug.Log ("Tiles/" + mapXml.map.mapTiles [i].tileObjectName);
			GameObject tile = Instantiate(Resources.Load("Tiles/" + mapXml.map.mapTiles[i].tileObjectName), position, Quaternion.identity) as GameObject;
			tile.transform.parent = gameObject.transform;
			map [i] = tile;
		}
	}
}