using UnityEngine;
using System.Collections;

public class ShieldCollect : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.tag == "Player") {
			coll.SendMessage ("addShield", SendMessageOptions.DontRequireReceiver);
			Destroy(gameObject);
		}
	}
}
