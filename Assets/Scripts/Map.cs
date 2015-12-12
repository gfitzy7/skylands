using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour {

	private int mapWidth = 25;
	private int mapHeight = 40;
	private int[] map;
	
	private GameObject selectedTile = null;
	
	public Sprite water;
	public Sprite grass;

	enum Tile{
		Water = 0,
		Grass = 1
	}

	void Start () {
		map = new int[mapWidth * mapHeight];
		
		for(int i = 0; i < mapWidth * mapHeight; i++){
			int tile = (Random.Range(0f, 1f) < 0.75f ? 0: 1);
			//int tile = 1;
			map[i] = tile;
			CreateTile(tile, i % mapWidth, i / mapWidth);
		}
	}
	
	private void CreateTile(int tile, int xPos, int yPos){
		GameObject hexTile = Instantiate(Resources.Load ("Hex")) as GameObject;;
		
		if(tile == Tile.Water.GetHashCode()){
			hexTile.GetComponent<SpriteRenderer>().sprite = water;
		}
		else if(tile == Tile.Grass.GetHashCode()){
			hexTile.GetComponent<SpriteRenderer>().sprite = grass;
		}
		
		if(hexTile){
			hexTile.transform.parent = gameObject.transform;
			if(yPos % 2 == 0){
				hexTile.transform.position = new Vector3((3f * xPos) / 2f, yPos * Mathf.Sqrt(3) / 4f, 0);
			}
			else{
				hexTile.transform.position = new Vector3(0.75f + (3f * xPos) / 2f, yPos * Mathf.Sqrt(3) / 4f, 0);
			}
			
		}
	}
}
