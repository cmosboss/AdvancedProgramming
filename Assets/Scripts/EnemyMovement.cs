using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rigidbody2D.AddForce (gameObject.transform.up * -1);
		rigidbody2D.AddForce (gameObject.transform.right);
	}
}
