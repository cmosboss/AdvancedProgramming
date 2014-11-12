using UnityEngine;
using System.Collections;

public class DaBomb : PlayerDecorator {

	public DaBomb(PlayerComponent player)
		: base (player)
	{

	}
	
	public override void Special()
	{
		LayBomb ();
	}

	private void LayBomb(){

	}

}
