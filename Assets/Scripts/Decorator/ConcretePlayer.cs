using UnityEngine;
using System.Collections;

public class ConcretePlayer : PlayerComponent {

	
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
		numSpecials = 3;
	}

	public override void Fire(Transform t, Transform p){
		Transform bullet = Transform.Instantiate(p,t.position, t.rotation) as Transform;
		//Instantiate(p,t.position, t.rotation); //as GameObject;
	}

	public override void Special(Transform t, Transform[] s){

	}
}
