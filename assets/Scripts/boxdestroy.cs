using UnityEngine;
using System.Collections;

public class boxdestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D other) {
			if(other.gameObject.transform.localScale.y == 6){
			other.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -1000));
			_GM.Score+=50;
			Destroy (this.gameObject);
			}
	}
}