using UnityEngine;
using System.Collections;

public class HexTile : MonoBehaviour {

	void OnMouseEnter(){
		gameObject.GetComponent<SpriteRenderer>().enabled = false;
	}
	
	void OnMouseExit(){
		gameObject.GetComponent<SpriteRenderer>().enabled = true;
	}
}
