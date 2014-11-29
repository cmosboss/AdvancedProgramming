using UnityEngine;
using System.Collections;

public class Pizza : PlayerDecorator {

	public Pizza(PlayerComponent player)
		: base (player)
	{

	}

	public override void Fire(Transform t, Transform p)
	{
		base.Fire (t,p);
	}

	public override void Special()
	{
		
	}
}
