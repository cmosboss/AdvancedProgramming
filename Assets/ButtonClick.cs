using UnityEngine;
using System.Collections;

public class ButtonClick : MonoBehaviour {

	public int scene;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void click(){
		Application.LoadLevel(scene);
	}
}
