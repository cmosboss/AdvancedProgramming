using UnityEngine;
using System.Collections;

public class MysteryBoxCollect : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.tag == "Player") {
			coll.SendMessage ("addMysteryBox", SendMessageOptions.DontRequireReceiver);
			Destroy(gameObject);
		}
	}
}
