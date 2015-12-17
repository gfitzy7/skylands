using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {

	public float cameraSpeed = 5;

	void Update() {
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			gameObject.transform.position = gameObject.transform.position + cameraSpeed * Time.deltaTime * Vector3.left;
		}
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			gameObject.transform.position = gameObject.transform.position + cameraSpeed * Time.deltaTime * Vector3.right;
		}
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
			gameObject.transform.position = gameObject.transform.position + cameraSpeed * Time.deltaTime * Vector3.up;
		}
		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
			gameObject.transform.position = gameObject.transform.position + cameraSpeed * Time.deltaTime * Vector3.down;
		}
	}
}