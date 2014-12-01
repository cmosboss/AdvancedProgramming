using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ConcretePlayer : PlayerComponent {

	public int pooledAmount = 20;
	List<GameObject> bullets;
	
	//constructor
	public ConcretePlayer()
	{
		//initialize variables
		maxHealth = 100;
		health = maxHealth;
		cash = 0;
		damage = 10;
		speed = 10;
		range = 10;
		armour = 0;
		numSpecials = 6;
	}

	public override void Fire(Transform t, Transform p, GameObject o){

		if (o == null) return;
		o.transform.position = t.position;
		o.SetActive (true);

	}

	public override void Special(Transform t, Transform[] s){

	}
}
