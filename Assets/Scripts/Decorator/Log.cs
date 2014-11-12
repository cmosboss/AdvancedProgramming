using UnityEngine;
using System.Collections;

public class Log : PlayerDecorator{

	public Log(PlayerComponent player)
		: base (player)
	{
		ConcretePlayer.maxHealth += 15;
		ConcretePlayer.speed -= 5;
	}

	public override void Special()
	{

	}
}
