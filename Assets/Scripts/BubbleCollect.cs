using UnityEngine;
using System.Collections;

public class BubbleCollect : MonoBehaviour {

	public float secsAlive;

	void Start()
	{
		if (transform.name != "BubblePrefab")//only  destroys if it is a clone placed by the player
			Destroy (gameObject, secsAlive);
	}
	
	/// <summary>
	/// Raises the trigger enter2 d event.
	/// </summary>
	/// <param name="coll">Coll.</param>
	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.tag == "Player") {
			coll.SendMessage ("addBubble", SendMessageOptions.DontRequireReceiver);
			if(transform.name == "BubblePrefab") //Destroys original prefabs placed in level but not clones that the player lays
				Destroy(gameObject);
		}
	}
}
