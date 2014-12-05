using UnityEngine;
using System.Collections;

public class saveScene : MonoBehaviour {

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
            coll.gameObject.transform.position = new Vector3(37, -7, 0);

            world.GetComponent<Originator>().saveScene();
            world.GetComponent<Factory>().destroyAll();
        }
    }
}
