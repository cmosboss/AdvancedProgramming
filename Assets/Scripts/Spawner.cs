using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] enemies;


	void Update(){

		if (Input.GetButtonDown("Jump"))
			Instantiate(enemies[Random.Range(0,enemies.Length)], transform.position, Quaternion.identity);
	}
}
