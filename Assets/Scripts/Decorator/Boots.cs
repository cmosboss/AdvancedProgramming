using UnityEngine;
using System.Collections;

public class Boots : PlayerDecorator {

	public Boots(PlayerComponent player)
		: base (player)
	{
		player.speed += 15;
		player.maxHealth -= 5;
	}

	public override void Fire(Transform t, Transform p)
	{
		base.Fire (t,p);
	}

	public override void Special(Transform t,Transform[] s)
	{
		
	}
}
