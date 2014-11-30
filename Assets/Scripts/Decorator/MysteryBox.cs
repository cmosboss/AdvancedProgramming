using UnityEngine;
using System.Collections;

public class MysteryBox : PlayerDecorator {



	public MysteryBox(PlayerComponent player)
		: base (player)
	{
		int rand = Random.Range (0, 5);

		health = player.health;
		maxHealth = player.maxHealth;
		cash = player.cash;
		damage = player.damage;
		speed = player.speed;
		range = player.range;
		armour = player.armour;
		numSpecials = player.numSpecials;

		if (rand == 0)
			maxHealth += 25;
		else if (rand == 1)
			cash += 25;
		else if (rand == 2)
			damage +=  25;
		else if (rand == 3)
			speed += 25;
		else if (rand == 4)
			range +=  25;
		else if (rand == 5)
			armour += 25;
	}

	public override void Fire(Transform t, Transform p, GameObject o)
	{
		base.Fire (t,p, o);
	}

	public override void Special(Transform t,Transform[] s)
	{
		
	}
}
