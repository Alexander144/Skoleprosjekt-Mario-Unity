using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {
	public Animator animate;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		animate.SetFloat("start", 0);
	}
	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Player") {
			_GM.Coins += 1;
			_GM.Score += 200;
			animate.SetFloat ("start", 1);
			Destroy (this.gameObject);
		}
	}
}