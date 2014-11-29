using UnityEngine;
using System.Collections;

public class BombCollect : MonoBehaviour {

	public Transform explosion;
	public float secsAlive;

	void Start()
	{
		if (transform.name != "BombPrefab")//only "Blows up" if it is a clone placed by the player
			Invoke ("BlowUp",secsAlive);
	}
	/// <summary>
	/// Plays explosion "Animation" and destroys the bomb
	/// </summary>
	void BlowUp()
	{
		Instantiate (explosion,transform.position, Quaternion.identity);
		Destroy (gameObject);
	}
	/// <summary>
	/// Raises the trigger enter2 d event.
	/// </summary>
	/// <param name="coll">Coll.</param>
	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.tag == "Player") {
			coll.SendMessage ("addDaBomb", SendMessageOptions.DontRequireReceiver);
			if(transform.name == "BombPrefab") //Destroys original prefabs placed in level but not clones that the player lays
				Destroy(gameObject);
		}
	}
}
