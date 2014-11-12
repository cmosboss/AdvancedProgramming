using UnityEngine;
using System.Collections;

public class FireArrow : PlayerDecorator {

	public FireArrow(PlayerComponent player)
		: base (player)
	{
		ConcretePlayer.range += 5;	
		ConcretePlayer.damage += 5;	
	}
	
	public override void Special()
	{
		
	}
}
