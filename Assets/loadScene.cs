using UnityEngine;
using System.Collections;

public class loadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            GameObject world = GameObject.FindWithTag("GameController");
            world.GetComponent<Originator>().loadScene();

        }
    }
}
