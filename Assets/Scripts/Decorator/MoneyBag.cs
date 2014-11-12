using UnityEngine;
using System.Collections;

public class MoneyBag : PlayerDecorator {

	public MoneyBag(PlayerComponent player)
		: base (player)
	{
		ConcretePlayer.cash += 100;	
	}
	
	public override void Special()
	{
		
	}
}
