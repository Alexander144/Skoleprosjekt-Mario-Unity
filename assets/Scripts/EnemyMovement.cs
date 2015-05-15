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

		hittingWall = Physics2D.OverlapCircle (wallCheck.position, wallCheckRadius, whatIsWall);

		if (hittingWall) {
			moveLeft = !moveLeft;
		}
		if (moveLeft && check == true) {
			transform.localScale = new Vector3 (-0.5f, 0.5f, 0.5f);
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
		} else {
			if(check == true){
				transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
			}
		}
	}

}