using UnityEngine;
using System.Collections;

public class Shield : PlayerDecorator {

	public Shield(PlayerComponent player)
		: base (player)
	{
		health = player.health;
		maxHealth = player.maxHealth;
		cash = player.cash;
		damage = player.damage;
		speed = player.speed;
		range = player.range;
		armour = player.armour + 10;
	}

	public override void Fire(Transform t, Transform p)
	{
		base.Fire (t,p);
	}

	public override void Special(Transform t,Transform[] s)
	{
		
	}
}
