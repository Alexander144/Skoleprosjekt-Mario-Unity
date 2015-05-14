using UnityEngine;
using System.Collections;

public class Shrom : MonoBehaviour {
	 //Use this for initialization
	public Animator self;
	public bool traff = false;
	public static bool surf = false;

	void Start () {
		self = this.gameObject.GetComponent<Animator> ();
	}
//	 Update is called once per frame
	void Update () {
		if(GetComponent<Rigidbody2D>().velocity.x<1&&traff==false && surf == true){
	
			GetComponent<Rigidbody2D>().AddForce(new Vector2(6, 0));
		}
		if(GetComponent<Rigidbody2D>().velocity.x>-1&&traff==true && surf == true){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(-6, 0));
		}
	}
	void OnCollisionEnter2D (Collision2D other) {
		if (other.collider.tag == "Ror") {
			traff = true;
		}
	}
	void OnTriggerEnter2D(Collider2D other){
			surf = true;
		self.enabled = false;
	}
}
