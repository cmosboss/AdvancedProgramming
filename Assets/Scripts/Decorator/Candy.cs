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
	public override void Special()
	{			
		LayCandy ();
	}
		
	private void LayCandy(){
			
	}
}
