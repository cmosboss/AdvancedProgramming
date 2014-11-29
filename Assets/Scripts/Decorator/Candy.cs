using UnityEngine;
using System.Collections;

public class Candy : PlayerDecorator {
		
	public Candy(PlayerComponent player)
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
			if (special.name == "CandyPrefab")
				LayCandy (t, special);
		}		

	}
		
	private void LayCandy(Transform t, Transform s)
	{
		Transform candy = Transform.Instantiate(s,t.position, t.rotation) as Transform;	
	}
}
