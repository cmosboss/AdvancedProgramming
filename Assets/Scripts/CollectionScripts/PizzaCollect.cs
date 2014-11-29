using UnityEngine;
using System.Collections;

public class PizzaCollect : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.tag == "Player") {
			coll.SendMessage ("addPizza", SendMessageOptions.DontRequireReceiver);
			Destroy(gameObject);
		}
	}
}
