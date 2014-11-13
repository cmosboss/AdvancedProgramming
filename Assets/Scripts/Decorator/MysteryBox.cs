using UnityEngine;
using System.Collections;

public class MysteryBox : PlayerDecorator {



	public MysteryBox(PlayerComponent player)
		: base (player)
	{
		int rand = Random.Range (0, 5);

		if (rand == 0)
			ConcretePlayer.maxHealth += 25;
		else if (rand == 1)
			ConcretePlayer.cash += 25;
		else if (rand == 2)
			ConcretePlayer.damage += 25;
		else if (rand == 3)
			ConcretePlayer.speed += 25;
		else if (rand == 4)
			ConcretePlayer.range += 25;
		else if (rand == 5)
			ConcretePlayer.armour += 25;
	}
	
	public override void Special()
	{
		
	}
}
