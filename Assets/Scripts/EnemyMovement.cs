using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	private Vector3 player;
	private Vector2 playerDir;
	private float xdif;
	private float ydif;
	public float speed = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		player = GameObject.Find ("Player").transform.position;

		xdif = player.x - transform.position.x;
		ydif = player.y - transform.position.y;

		playerDir = new Vector2 (xdif, ydif);

		rigidbody2D.AddForce (playerDir.normalized * speed);//normailized so the amount of force is not dependent on the dif between the two

	}
}
