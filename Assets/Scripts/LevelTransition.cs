using UnityEngine;
using System.Collections;

public class LevelTransition : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D coll) {
        if (coll.gameObject.tag == "Player") 
        {
            //Application.LoadLevel (sceneToLoad);
            GameObject world = GameObject.FindWithTag("GameController");
            world.GetComponent<Factory>().destroyAll();
            coll.gameObject.transform.position = new Vector3(37, -7, 0);
		
        }

	}
}
