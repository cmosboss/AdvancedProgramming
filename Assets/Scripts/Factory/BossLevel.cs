using UnityEngine;
using System.Collections;

public class BossLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Boss Level Created, Now Instantiating Objects");
        GameObject enemey = Instantiate(Resources.Load("EnemyPrefabs/Skeletor")) as GameObject;
        float height = Random.Range(-7, 1);
        float width = Random.Range(21, 25);
        enemey.transform.eulerAngles = new Vector3(0, 0, Random.Range(0, 180));
        enemey.transform.position = new Vector3(width, height, 0);
        enemey.transform.localScale = new Vector3(2, 2, 0);
        enemey.gameObject.tag = "Enemy";
        enemey.gameObject.GetComponent<EnemyDamage>().health = enemey.gameObject.GetComponent<EnemyDamage>().health*15;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
