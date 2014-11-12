using UnityEngine;
using System.Collections;

public class Shield : PlayerDecorator {

	public Shield(PlayerComponent player)
		: base (player)
	{
		ConcretePlayer.armour += 100;	
	}
	
	public override void Special()
	{
		
	}
}
