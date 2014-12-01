using UnityEngine;
using System.Collections;

public class PlayerProjectile : MonoBehaviour {

	public float speed;
	public int dmg = 15;

	private float destroyTime;

	void Awake(){
		DontDestroyOnLoad (transform.gameObject);
		destroyTime = Mathf.Sqrt(PlayerMovement.player.range)/2;
	}

	void OnEnable()
	{
		dmg += PlayerMovement.player.damage;//players damage is added to the projectiles base damage
		destroyTime = Mathf.Sqrt(PlayerMovement.player.range)/2;//players range is used to determine how long the projectile stays enabled
		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);//float;
		Quaternion rot = Quaternion.LookRotation (transform.position - mousePosition,Vector3.forward);
		transform.rotation = rot; //sets rotation to look at mouse
		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z); //so it only rotates on Z-axis
		Invoke ("Destroy", destroyTime);
	}

	void Destroy()
	{
		gameObject.SetActive (false);
	}

	void OnDisable()
	{
		CancelInvoke ();
	}

	// Update is called once per frame
	void Update () {

		float velocity = (speed * Time.deltaTime);

		transform.Translate(Vector3.up * velocity);
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag != "Player") 
		{
			coll.gameObject.SendMessage ("ApplyDamage", dmg, SendMessageOptions.DontRequireReceiver); 
			Destroy();
		}
	}
}
