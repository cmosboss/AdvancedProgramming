using UnityEngine;
using System.Collections;

public abstract class PlayerDecorator : PlayerComponent{
	
	PlayerComponent player;

	public PlayerDecorator(PlayerComponent player){
		this.player = player;
	}

	public override abstract void Special();
	
	public override void Fire(Transform t, Transform p){
		if (player != null)
			player.Fire (t,p);
	}
}
