using UnityEngine;
using System.Collections;

public class SpikeyBallCollect : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.tag == "Player") {
			coll.SendMessage ("addSpikeyBall", SendMessageOptions.DontRequireReceiver);
			Destroy(gameObject);
		}
	}
}
