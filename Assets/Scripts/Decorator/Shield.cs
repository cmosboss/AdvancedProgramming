using UnityEngine;
using System.Collections;

public class Shield : PlayerDecorator {

	public Shield(PlayerComponent player)
		: base (player)
	{
		player.armour += 100;	
	}

	public override void Fire(Transform t, Transform p)
	{
		base.Fire (t,p);
	}

	public override void Special()
	{
		
	}
}
