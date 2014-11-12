using UnityEngine;
using System.Collections;

public class SpikeyBall : PlayerDecorator {

	public SpikeyBall(PlayerComponent player)
		: base (player)
	{
		ConcretePlayer.damage += 10;	
	}
	
	public override void Special()
	{
		
	}
}
