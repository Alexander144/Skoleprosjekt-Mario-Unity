using UnityEngine;
using System.Collections;

public class MarioController : MonoBehaviour {
	public int speed;
	public int jumpForce = 4;
	public Rigidbody2D rb;

	public void Attributes(){
		
	
	}

	void Awake(){
		rb = GetComponent<Rigidbody2D>();
	}
	void FixedUpdate () {
		speed = 4;
		Move ();
		Jump ();
	}

	void Move (){
		transform.Translate (new Vector2(Input.GetAxis("Horizontal")*speed*Time.deltaTime,0));
	}
	void Jump(){
		if(Input.GetButtonDown("Jump")){
		rb.velocity = new Vector2(rb.velocity.x,jumpForce);
		}
	}
}
