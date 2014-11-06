using UnityEngine;
using System.Collections;

public class EnemyDamage : MonoBehaviour {

	public float health;
    public GameObject Potion;
    public GameObject Coin;
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
        int drop = Random.Range(0, 2);
        if (drop == 0)
        {
            Instantiate(Potion, transform.position, Quaternion.identity);
        }
        else if (drop == 1)
        {
            Instantiate(Coin, transform.position, Quaternion.identity);
        }
        else
        {
            //no drop 
        }
    }

	void ApplyDamage(float damage)
	{
		health -= damage;	
	}	
}
