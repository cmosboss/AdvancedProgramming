using UnityEngine;
using System.Collections;

public class DaBomb : PlayerDecorator {

	public GameObject b;

	public DaBomb(PlayerComponent player)
		: base (player)
	{

	}

	public override void Fire(Transform t, Transform p)
	{
		base.Fire (t,p);
	}

	public override void Special()
	{
		LayBomb ();
	}

	private void LayBomb()
	{

	}

}
