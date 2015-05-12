using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using AssemblyCSharp;

public class WorldLevelManager : MonoBehaviour {

	public GameObject[] levelTiles;
	public GameObject animatedQuestionmark;
	public GameObject[] levelObjects;

	private Transform worldLevelHolder;
	private List<Vector3> gridPositions = new List<Vector3>();
	private BaseWorldDefinition currentWorld;

	void InitializeList()
	{
		gridPositions.Clear ();
		for (int y=0; y<currentWorld.GetMaxY(); y++) {
			for(int x=0;x<currentWorld.GetMaxX ();x++)
			{
				gridPositions.Add (new Vector3(x,y,0f));
			}
		}
	}

	void worldLevelSetup()
	{
		worldLevelHolder = new GameObject ("WorldLevel").transform;
		for (int y=0; y<currentWorld.GetMaxY(); y++) {
			for(int x=0;x<currentWorld.GetMaxX ();x++)
			{
				int tileNumber = currentWorld.GetTileAtXY(x,(currentWorld.GetMaxY ()-1)-y);
				if (tileNumber == 8) 
				{
					GameObject toInstantiate = animatedQuestionmark;
					GameObject instance = Instantiate (toInstantiate,new Vector3(x,y,0f),Quaternion.identity) as GameObject;
					instance.transform.localScale = new Vector3(6.3f,6.3f,0f);
					instance.transform.SetParent(worldLevelHolder);
				}
				if (tileNumber > 0 && tileNumber < 34)
				{
			    GameObject toInstantiate = levelTiles[tileNumber-1];
				GameObject instance = Instantiate (toInstantiate,new Vector3(x,y,0f),Quaternion.identity) as GameObject;
				instance.transform.localScale = new Vector3(6.3f,6.3f,0f);
				instance.transform.SetParent(worldLevelHolder);
				}
			}
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	void LayoutObject(GameObject[] tileArray)
	{
	}

	public void SetupWorldLevel(int world, int level)
	{
		switch (world) {
		case 1: switch(level)
			{
			case 1: currentWorld = new World_1_1();
				break;

			}
			break;
		}
		if (currentWorld == null) {
			Debug.Log ("current world er ikke definert. Avbryter");
			return;
		}
		worldLevelSetup ();
		InitializeList ();
		LayoutObject (levelTiles);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
