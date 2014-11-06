using UnityEngine;
using System.Collections;

public class PlayerProjectile : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);//float;
		Quaternion rot = Quaternion.LookRotation (transform.position - mousePosition,Vector3.forward);
		transform.rotation = rot; //sets rotation to look at mouse
		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z); //so it only rotates on Z-axis
	}
	
	// Update is called once per frame
	void Update () {

		float velocity = (speed * Time.deltaTime);

		transform.Translate(Vector3.up * velocity);
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag != "Player") 
		{
			coll.gameObject.SendMessage ("ApplyDamage", 25); 
			Destroy(gameObject);
		}
	}
}
