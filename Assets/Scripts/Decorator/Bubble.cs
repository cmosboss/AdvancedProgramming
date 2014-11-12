using UnityEngine;
using System.Collections;

public class Bubble : PlayerDecorator {
	
	public Bubble(PlayerComponent player)
		: base (player)
	{
		
	}
	
	public override void Special()
	{
		MakeBubble ();
	}
	
	private void MakeBubble(){
		
	}
}
