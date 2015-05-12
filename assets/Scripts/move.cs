using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	private Animator animate;
	private int speed = 10;
	private int jump = 1;
	// Use this for initialization
	void Start () {
		animate = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(Input.GetButton("Jump")){
			GetComponent<Rigidbody2D>().AddForce(Vector2.up*jump, ForceMode2D.Impulse);
			_GM.Coins+=1;
		}
		float aSpeed = Input.GetAxis ("Horizontal");
		animate.SetFloat("speed", Mathf.Abs(aSpeed));
		if(aSpeed > 0){
			transform.localScale = new Vector3(6, 5, 1);
		}
		else if(aSpeed < 0){
			transform.localScale = new Vector3(-6, 5, 1);
		}
		this.GetComponent<Rigidbody2D>().velocity = new Vector2 (aSpeed*speed, this.GetComponent<Rigidbody2D>().velocity.y);
	}
}
