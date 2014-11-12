using UnityEngine;
using System.Collections;

public class MysteryBox : PlayerDecorator {

	public MysteryBox(PlayerComponent player)
		: base (player)
	{
		//logic for random trait here.  Not yet implemented
		ConcretePlayer.cash += 25;	
	}
	
	public override void Special()
	{
		
	}
}
