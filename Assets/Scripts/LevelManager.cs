using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public static LevelManager LevelMgr { get; private set; }

	void Awake()
	{
		if (LevelMgr != null && LevelMgr != this) {
			Destroy (gameObject);
		}

		LevelMgr = this;
		DontDestroyOnLoad (gameObject);
	}

	public void loadScene(string level)
	{
		SceneManager.LoadScene (level);
	}

	public void loadScene(int sceneID)
	{
		SceneManager.LoadScene (sceneID);
	}
}