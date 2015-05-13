using UnityEngine;
using System.Collections;

public class Shrom : MonoBehaviour {
	// Use this for initialization
	public Animator self;
	public bool traff = false;
	public bool surf = false;
	void Start () {
		self = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x > 21.01 && transform.position.x > 5.100) {
			surf = true;
		}
		if(GetComponent<Rigidbody2D>().velocity.x<1&&traff==false && surf == true){
			self.enabled = false;
			GetComponent<Rigidbody2D>().AddForce(new Vector2(6, 0));
		}
		if(GetComponent<Rigidbody2D>().velocity.x>-1&&traff==true && surf == true){
			GetComponent<Rigidbody2D>().AddForce(new Vector2(-6, 0));
		}
	}
	void OnCollisionEnter2D (Collision2D other) {
		if(other.collider.tag == "Ror"){
			traff=true;
		}
		
	}
}
