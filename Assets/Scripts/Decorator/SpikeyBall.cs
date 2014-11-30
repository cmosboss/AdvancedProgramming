using UnityEngine;
using System.Collections;

public class SpikeyBall : PlayerDecorator {

	public SpikeyBall(PlayerComponent player)
		: base (player)
	{
		health = player.health;
		maxHealth = player.maxHealth;
		cash = player.cash;
		damage = player.damage + 10;
		speed = player.speed;
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
