using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	
	public float moveSpeed;
	public bool moveLeft;
	public Animator animate;
	public Transform wallCheck;
	public float wallCheckRadius;
	public LayerMask whatIsWall;
	private bool hittingWall;
	public static bool check = false;
	public static bool moveEnemy = false;
	public static bool kill = false;
	void Start () {

	}
	
	
	void Update () {
		// Fiendene beveger seg, og vender om når de treffer en collider
			hittingWall = Physics2D.OverlapCircle (wallCheck.position, wallCheckRadius, whatIsWall);
			
			if (hittingWall) {
				moveLeft = !moveLeft;
			}
			if (moveLeft ) {
				transform.localScale = new Vector3 (-0.5f, 0.5f, 0.5f);
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
			} else {
					transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
					GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
			}
			animate.SetBool("Walk", true);
		}

	void OnCollisionEnter2D (Collision2D other) {
		// Fiendene blir fjernet om de faller ut av banen
		if (other.collider.tag == "Border") {
			Destroy(this.gameObject);
		}
	}
}