using UnityEngine;
using System.Collections;

public class Bubble : PlayerDecorator {
	
	public Bubble(PlayerComponent player)
		: base (player)
	{
		
	}

	public override void Fire(Transform t, Transform p)
	{
		base.Fire (t,p);
	}

	public override void Special()
	{
		MakeBubble ();
	}
	
	private void MakeBubble()
	{
		
	}
}
