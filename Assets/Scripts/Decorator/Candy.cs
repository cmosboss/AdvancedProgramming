using UnityEngine;
using System.Collections;

public class Candy : PlayerDecorator {
		
	public Candy(PlayerComponent player)
			: base (player)
	{
		health = player.health;
		maxHealth = player.maxHealth;
		cash = player.cash;
		damage = player.damage;
		speed = player.speed;
		range = player.range;
		armour = player.armour;
		numSpecials = player.numSpecials;
	}
		
	public override void Fire(Transform t, Transform p, GameObject o)
	{
		base.Fire (t,p, o);
	}
	public override void Special(Transform t, Transform[] s)
	{	
		foreach(Transform special in s){
			if (special.name == "CandyPrefab")
				LayCandy (t, special);
		}		

	}
		
	private void LayCandy(Transform t, Transform s)
	{
		numSpecials --;
		Transform candy = Transform.Instantiate(s,t.position, t.rotation) as Transform;	
	}
}
