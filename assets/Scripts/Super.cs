using UnityEngine;
using System.Collections;

public class Super : MonoBehaviour {
	public Animator shroms;
	public Animator flower;
	public GameObject shrom;
	public static bool go = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter2D (Collider2D other) {
		Destroy (this.gameObject);
		_GM.Super++;

		if (_GM.Super == 1) {
			go = true;
			shroms.SetFloat("mush", 3);
		} else {
			flower.SetFloat("super", 6);
		}

	}
}
