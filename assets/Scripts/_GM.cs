using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class _GM : MonoBehaviour {
	public static int Score;
	public static int Coins;
	public static int Time = 40000;
	public static int Lives;

	public static int Super = 0;
	public Text ScoreText;
	public Text CoinsText;
	public Text TimeText;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		ScoreText.text = "" + Score.ToString ("000000");
		if(Coins>=99){
			Lives++;
			Coins=0;
		}
		CoinsText.text = "X " + Coins.ToString ("00");
		if(Time>0){
			Time--;
			Time--;
			Time--;
			Time--;
		}
		TimeText.text = "" + Time/100;
	}
}
