using UnityEngine;
using System.Collections;

public class BootsCollect : MonoBehaviour {

	/// <summary>
	/// Raises the trigger enter2 d event.
	/// </summary>
	/// <param name="coll">Coll.</param>
	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.tag == "Player") {
			coll.SendMessage ("addBoots", SendMessageOptions.DontRequireReceiver);
			Destroy(gameObject);
		}
	}
}
