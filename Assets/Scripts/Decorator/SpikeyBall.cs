using UnityEngine;
using System.Collections;

public class SpikeyBall : PlayerDecorator {

	public SpikeyBall(PlayerComponent player)
		: base (player)
	{
		player.damage += 10;	
	}

	public override void Fire(Transform t, Transform p)
	{
		base.Fire (t,p);
	}

	public override void Special()
	{
		
	}
}
