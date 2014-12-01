using UnityEngine;
using System.Collections;

public class EnemyDamage : MonoBehaviour {

	public float health;
	public GameObject[] droppables;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (health < 0) 
        {
            ObjectDies();
            Destroy(gameObject);
        }
 
	}

    void ObjectDies()
    {
        //drop object at random on death
		Instantiate(droppables[Random.Range(0,droppables.Length - 1)], transform.position, Quaternion.identity);
     
    }

	void ApplyDamage(float damage)
	{
		health -= damage;	
	}	
}
