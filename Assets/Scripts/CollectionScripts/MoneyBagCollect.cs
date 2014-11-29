using UnityEngine;
using System.Collections;

public class MoneyBagCollect : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.tag == "Player") {
			coll.SendMessage ("addMoneyBag", SendMessageOptions.DontRequireReceiver);
			Destroy(gameObject);
		}
	}
}
