using UnityEngine;
using System.Collections;

public class DaBomb : PlayerDecorator {

	public GameObject b;

	public DaBomb(PlayerComponent player)
		: base (player)
	{
		health = player.health;
		maxHealth = player.maxHealth;
		cash = player.cash;
		damage = player.damage;
		speed = player.speed;
		range = player.range;
		armour = player.armour;
		numSpecials = player.numSpecials;
	}

	public override void Fire(Transform t, Transform p, GameObject o)
	{
		base.Fire (t,p, o);
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
		numSpecials --;
		Transform bomb = Transform.Instantiate(s,t.position, t.rotation) as Transform;

	}

}
