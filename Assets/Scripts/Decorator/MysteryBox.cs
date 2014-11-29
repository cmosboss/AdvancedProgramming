using UnityEngine;
using System.Collections;

public class MysteryBox : PlayerDecorator {



	public MysteryBox(PlayerComponent player)
		: base (player)
	{
		int rand = Random.Range (0, 5);

		if (rand == 0)
			player.maxHealth += 25;
		else if (rand == 1)
			player.cash += 25;
		else if (rand == 2)
			player.damage += 25;
		else if (rand == 3)
			player.speed += 25;
		else if (rand == 4)
			player.range += 25;
		else if (rand == 5)
			player.armour += 25;
	}

	public override void Fire(Transform t, Transform p)
	{
		base.Fire (t,p);
	}

	public override void Special()
	{
		
	}
}
