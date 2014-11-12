using UnityEngine;
using System.Collections;

public class DecoratorClient : MonoBehaviour {

	PlayerComponent player;

	// Use this for initialization
	void Start () {
		player = new ConcretePlayer();
	}

	public void addLog(){
		player = new Log (player);
	}

	public void addMoneyBag(){
		player = new MoneyBag (player);
	}

	public void addShield(){
		player = new Shield (player);
	}

	public void addBoots(){
		player = new Boots (player);
	}

	public void addMysteryBox(){
		player = new MysteryBox (player);
	}

	public void addFireArrow(){
		player = new FireArrow (player);
	}

	public void addSpikeyBall(){
		player = new SpikeyBall (player);
	}

	public void addPizza(){
		player = new Pizza (player);
	}

	public void addDaBomb(){
		player = new DaBomb (player);
	}

	public void addBubble(){
		player = new Bubble (player);
	}

	public void addCandy(){
		player = new Candy (player);
	}
}
