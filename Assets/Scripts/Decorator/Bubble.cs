using UnityEngine;
using System.Collections;

public class Bubble : PlayerDecorator {
	
	public Bubble(PlayerComponent player)
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

	public override void Fire(Transform t, Transform p)
	{
		base.Fire (t,p);
	}

	public override void Special(Transform t, Transform[] s)
	{
		foreach(Transform special in s){
			if (special.name == "BubblePrefab")
			MakeBubble (t, special);
		}
	}
	
	private void MakeBubble(Transform t, Transform s)
	{
		numSpecials --;
		Transform bub = Transform.Instantiate(s,t.position, t.rotation) as Transform;
		bub.parent = t;

	}
}
