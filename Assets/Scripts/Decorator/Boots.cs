using UnityEngine;
using System.Collections;

public class Boots : PlayerDecorator {

	public Boots(PlayerComponent player)
		: base (player)
	{
		health = player.health;
		maxHealth = player.maxHealth - 5;
		cash = player.cash;
		damage = player.damage;
		speed = player.speed + 15;
		range = player.range;
		armour = player.armour;
		numSpecials = player.numSpecials;

	}

	public override void Fire(Transform t, Transform p, GameObject o)
	{
		base.Fire (t,p, o);
	}

	public override void Special(Transform t,Transform[] s)
	{
		
	}
}
