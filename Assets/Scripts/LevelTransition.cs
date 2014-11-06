using UnityEngine;
using System.Collections;

public class LevelTransition : MonoBehaviour {

	public string sceneToLoad;

	void OnTriggerEnter2D(Collider2D coll) {
		//if (coll.gameObject.tag == "Enemy")
		//	coll.gameObject.SendMessage ("ApplyDamage", 10);
		//else 
		Application.LoadLevel (sceneToLoad);
		
	}
}
