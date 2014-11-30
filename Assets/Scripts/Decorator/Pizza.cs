using UnityEngine;
using System.Collections;

public class Pizza : PlayerDecorator {

	public Pizza(PlayerComponent player)
		: base (player)
	{
		health = player.health;
		maxHealth = player.maxHealth;
		cash = player.cash;
		damage = player.damage;
		speed = player.speed;
		range = player.range;
		armour = player.armour;
		numSpecials = player.numSpecials + 1;
	}

	public override void Fire(Transform t, Transform p, GameObject o)
	{
		base.Fire (t,p, o);
	}

	public override void Special(Transform t,Transform[] s)
	{
		
	}
}
