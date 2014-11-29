using UnityEngine;
using System.Collections;

public class FireArrow : PlayerDecorator {

	public FireArrow(PlayerComponent player)
		: base (player)
	{
		player.range += 5;	
		player.damage += 5;	
	}

	public override void Fire(Transform t, Transform p)
	{
		base.Fire (t,p);
	}

	public override void Special()
	{
		
	}
}
