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

	public override void Special(Transform t, Transform[] s)
	{
		foreach(Transform special in s){
			if (special.name == "BombPrefab")
				LayBomb (t,special);
		}
	}

	private void LayBomb(Transform t, Transform s)
	{
		Transform bomb = Transform.Instantiate(s,t.position, t.rotation) as Transform;
	}

}
