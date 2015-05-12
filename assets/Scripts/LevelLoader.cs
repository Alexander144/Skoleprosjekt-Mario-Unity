using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {

	public GameObject gameManager;

	// Use this for initialization
	void Awake () {
	if (GameManager.instance == null)
			Instantiate (gameManager);
	}
	
}
