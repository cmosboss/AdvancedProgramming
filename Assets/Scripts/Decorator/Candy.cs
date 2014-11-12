using UnityEngine;
using System.Collections;

public class Candy : PlayerDecorator {
		
	public Candy(PlayerComponent player)
			: base (player)
		{
			
		}
		
		public override void Special()
		{
			LayCandy ();
		}
		
		private void LayCandy(){
			
		}
}
