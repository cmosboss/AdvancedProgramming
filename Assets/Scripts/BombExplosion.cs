using UnityEngine;
using System.Collections;

public class BombExplosion : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll) {

		coll.gameObject.SendMessage ("ApplyDamage", 99999); 
			

	}
}
