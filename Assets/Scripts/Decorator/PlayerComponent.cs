using UnityEngine;
using System.Collections;

public abstract class PlayerComponent{

	public int maxHealth { get; set; }
	public int health { get; set; }
	public int cash { get; set; }
	public int damage { get; set; }
	public int speed { get; set; }
	public int range { get; set; }
	public int armour  { get; set; }
	public int numSpecials { get; set; }
	public Transform special { get; set; }

	public abstract void Fire(Transform t, Transform p);
	public abstract void Special(Transform t, Transform[] s);
	
}
