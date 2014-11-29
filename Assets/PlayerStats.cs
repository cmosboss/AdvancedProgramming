using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {

	public Text stats;
	
	public void Start () {

	}

	public void Update(){

		stats.text = "Health: " + PlayerMovement.player.health.ToString () +
						"\nMax Health: " + PlayerMovement.player.maxHealth.ToString () + 
						"\nCash: " + PlayerMovement.player.cash.ToString () +
						"\nDamage: " + PlayerMovement.player.damage.ToString () +
						"\nSpeed: " + PlayerMovement.player.speed.ToString () +
						"\nRange: " + PlayerMovement.player.range.ToString () +
						"\nArmour: " + PlayerMovement.player.armour.ToString () +
						"\nNumber of specials per room: " + PlayerMovement.player.numSpecials.ToString ();
	}
}
