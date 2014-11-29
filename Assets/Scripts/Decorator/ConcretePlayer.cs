using UnityEngine;
using System.Collections;

public class ConcretePlayer : PlayerComponent {


	void Start(){


	}

	public override void Fire(Transform t, Transform p){
		Transform bullet = Transform.Instantiate(p,t.position, t.rotation) as Transform;
		//Instantiate(p,t.position, t.rotation); //as GameObject;
	}

	public override void Special(){

	}
}
