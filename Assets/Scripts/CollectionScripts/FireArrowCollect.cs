using UnityEngine;
using System.Collections;

public class FireArrowCollect : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.tag == "Player") {
			coll.SendMessage ("addFireArrow", SendMessageOptions.DontRequireReceiver);
			Destroy(gameObject);
		}
	}
}
