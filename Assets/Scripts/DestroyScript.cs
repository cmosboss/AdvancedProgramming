using UnityEngine;
using System.Collections;

public class DestroyScript : MonoBehaviour {

	public float numSeconds;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, numSeconds);
	}
	

}
