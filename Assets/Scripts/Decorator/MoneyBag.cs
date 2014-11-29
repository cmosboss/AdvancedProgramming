using UnityEngine;
using System.Collections;

public class MoneyBag : PlayerDecorator {

	public MoneyBag(PlayerComponent player)
		: base (player)
	{
		player.cash += 100;	
	}

	public override void Fire(Transform t, Transform p)
	{
		base.Fire (t,p);
	}
	public override void Special(Transform t,Transform[] s)
	{
		
	}
}
