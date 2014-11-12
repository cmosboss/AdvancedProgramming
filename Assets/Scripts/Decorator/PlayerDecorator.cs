using UnityEngine;
using System.Collections;

public abstract class PlayerDecorator : PlayerComponent{
	
	PlayerComponent player;

	public abstract void Special();


	public PlayerDecorator(PlayerComponent player){

		this.player = player;

	}
}
