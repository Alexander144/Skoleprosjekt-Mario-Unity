using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	public WorldLevelManager levelScript;

	// Use this for initialization
	void Awake () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);

		levelScript = GetComponent<WorldLevelManager> ();
		InitGame ();
	}
	void InitGame()
	{
		levelScript.SetupWorldLevel (1,1);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
