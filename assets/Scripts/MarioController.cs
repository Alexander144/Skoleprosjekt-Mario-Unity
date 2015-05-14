using UnityEngine;
using System.Collections;

public class MarioController : MonoBehaviour {
	public int speed;
	public int jumpForce;
	public static bool shoot = false;

	private Rigidbody2D rb;

	private Animator anim;
	bool facingRight = true;

	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	
	void Awake(){
		anim = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D>();

	}
	void FixedUpdate () {

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("isGrounded", grounded);

		Move ();


	}

	void Update(){
		if(grounded == true && Input.GetButtonDown("Jump")){
			if(this.gameObject.transform.localScale.y == 6){
				jumpForce = 30;
			}
			else{jumpForce = 20;}
			anim.SetBool("isGrounded", false);
			rb.velocity = (new Vector2(rb.velocity.x,jumpForce));
		}

		if(shoot == true){

		}
	}
	
	void Move (){
		float aSpeed = Input.GetAxis ("Horizontal");
		if(aSpeed != 0 && Input.GetButtonDown ("Fire1")){
			transform.Translate (new Vector2 ( aSpeed * speed * Time.deltaTime, 0));
		} else if(aSpeed != 0){
			transform.Translate (new Vector2 ( aSpeed * (speed * 1.4f)* Time.deltaTime, 0));
		}

		anim.SetFloat ("speed", Mathf.Abs (aSpeed));
		if (aSpeed > 0 && !facingRight) {
			Flip(-1);

		} else if (aSpeed < 0 && facingRight){
			Flip(1); 

		}
	}

	void Flip(float move){
		facingRight = !facingRight;
		Vector2 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
		transform.Translate (new Vector2(move,0));
	}
	void OnCollisionEnter2D (Collision2D other) {
		if (other.collider.tag == "Shroom" && Super.go == true) {
			if(this.gameObject.transform.localScale.x > 0){
			this.gameObject.transform.localScale = new Vector2(6,6);
			}
			else{this.gameObject.transform.localScale = new Vector2(-6,6);}
			_GM.Score+=500;
			Destroy (other.gameObject);
		}
		if (other.collider.tag == "Flower") {
			shoot=true;
			Destroy (other.gameObject);
			if(this.gameObject.transform.localScale.x > 0){
				this.gameObject.transform.localScale = new Vector2(6,6);
			}
			else{this.gameObject.transform.localScale = new Vector2(-6,6);}
			_GM.Score+=500;
			Destroy (other.gameObject);
		}
	}
}
