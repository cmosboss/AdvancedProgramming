using UnityEngine;
using System.Collections;

public class FadeOut : MonoBehaviour {


    public Texture2D fadeTexture;
    public float fadeSpeed = 0.2f;
    public int  drawDepth = -1000;
 
    private float alpha = 0.0f; 
    private int fadeDir = -1;

    public bool fade = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI() 
    {
        if (fade == true) 
        {
            alpha -= fadeDir * fadeSpeed * Time.deltaTime;
            alpha = Mathf.Clamp01(alpha);

            Color myColor = GUI.color;
            myColor.a = alpha;
            GUI.color = myColor;

            GUI.depth = drawDepth;

            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeTexture);
        }
    }
}
