using UnityEngine;
using System.Collections;

public class Log : PlayerDecorator{

	public Log(PlayerComponent player)
		: base (player)
	{
		health = player.health;
		maxHealth = player.maxHealth + 15;
		cash = player.cash;
		damage = player.damage;
		speed = player.speed - 5;
		range = player.range;
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
