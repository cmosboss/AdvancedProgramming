using UnityEngine;
using System.Collections;

public class EnvLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Environmental Level Created, Now Instantiating Objects");
        for (int i = 0; i < 10; i++)
        {
            GameObject crate = Instantiate(Resources.Load("DoDads/Crate")) as GameObject;
            float height = Random.Range(-7, 1);
            float width = Random.Range(21, 37);
            crate.transform.eulerAngles = new Vector3(0, 0, Random.Range(0, 180));
            crate.transform.position = new Vector3(width, height, 0);
            crate.gameObject.tag = "dodad";
            crate.gameObject.name = "DoDads/Crate";

        }
        for (int i = 0; i < 4; i++)
        {
            GameObject chain = Instantiate(Resources.Load("DoDads/chain")) as GameObject;
            float height = Random.Range(-7, 1);
            float width = Random.Range(21, 37);
            chain.transform.eulerAngles = new Vector3(0, 0, Random.Range(0, 180));
            chain.transform.position = new Vector3(width, height, 0);
            chain.gameObject.tag = "Enemy";
            chain.gameObject.name = "DoDads/chain";


        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
