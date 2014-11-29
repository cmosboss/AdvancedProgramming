using UnityEngine;
using System.Collections;

public class LogCollect : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.tag == "Player") {
			coll.SendMessage ("addLog", SendMessageOptions.DontRequireReceiver);
			Destroy(gameObject);
		}
	}
}
