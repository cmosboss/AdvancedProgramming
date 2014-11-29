using UnityEngine;
using System.Collections;

public class Log : PlayerDecorator{

	public Log(PlayerComponent player)
		: base (player)
	{
		player.maxHealth += 15;
		player.speed -= 5;
	}

	public override void Fire(Transform t, Transform p)
	{
		base.Fire (t,p);
	}

	public override void Special(Transform t,Transform[] s)
	{
		
	}
}
