using UnityEngine;
using System.Collections;

public class BasicLevel : MonoBehaviour {

    private GameObject Skeletor;
	// Use this for initialization
	void Start () {
        Debug.Log("Basic Level Created, Now Instantiating Objects");
        for (int i = 0; i < 10; i++) 
        {
            GameObject crate = Instantiate(Resources.Load("DoDads/Crate")) as GameObject;
            float height = Random.Range(-7, 1);
            float width = Random.Range(21, 37);
            crate.transform.eulerAngles = new Vector3(0, 0, Random.Range(0,180));
            crate.transform.position = new Vector3(width, height, 0);
            crate.gameObject.tag = "dodad";
            crate.gameObject.name = "DoDads/Crate";

        }
        for (int i = 0; i < 10; i++)
        {

            int type = Random.Range(1, 3);
            if (type == 1)
            {
                GameObject enemey = Instantiate(Resources.Load("EnemyPrefabs/Skeletor")) as GameObject;
                float height = Random.Range(-7, 1);
                float width = Random.Range(21, 25);
                enemey.transform.eulerAngles = new Vector3(0, 0, Random.Range(0, 180));
                enemey.transform.position = new Vector3(width, height, 0);
                enemey.gameObject.tag = "Enemy";
                enemey.gameObject.name = "EnemyPrefabs/Skeletor";
            }
            else 
            {
                GameObject enemey = Instantiate(Resources.Load("EnemyPrefabs/Spyder")) as GameObject;
                float height = Random.Range(-7, 1);
                float width = Random.Range(21, 25);
                enemey.transform.eulerAngles = new Vector3(0, 0, Random.Range(0, 180));
                enemey.transform.position = new Vector3(width, height, 0);
                enemey.gameObject.tag = "Enemy";
                enemey.gameObject.name = "EnemyPrefabs/Spyder";


            }

        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}

}
