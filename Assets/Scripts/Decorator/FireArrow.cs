using UnityEngine;
using System.Collections;

public class FireArrow : PlayerDecorator {

	public FireArrow(PlayerComponent player)
		: base (player)
	{
		health = player.health;
		maxHealth = player.maxHealth;
		cash = player.cash;
		damage = player.damage + 5;
		speed = player.speed;
		range = player.range + 5;
		armour = player.armour;
		numSpecials = player.numSpecials;
	}

	public override void Fire(Transform t, Transform p)
	{
		base.Fire (t,p);
	}

	public override void Special(Transform t,Transform[] s)
	{
		
	}
}
