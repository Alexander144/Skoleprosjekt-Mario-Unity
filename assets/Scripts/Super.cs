using UnityEngine;
using System.Collections;

public class Super : MonoBehaviour {
	public Animator shroms;
	public Animator flower;
	public static bool go = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter2D (Collider2D other) {
		Destroy (this.gameObject);
		if (_GM.Super <= 0) {
			go = true;
			shroms.SetFloat("mush", 3);
		} else if(_GM.Super>=1){
			flower.SetFloat("super", 6);
		}

	}
}
