using UnityEngine;
using System.Collections;

public class Boots : PlayerDecorator {

	public Boots(PlayerComponent player)
		: base (player)
	{
		ConcretePlayer.speed += 15;
		ConcretePlayer.maxHealth -= 5;
	}
	
	public override void Special()
	{
		
	}
}
