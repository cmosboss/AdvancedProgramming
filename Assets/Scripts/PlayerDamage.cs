using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour {

    public float health = 100f;
	public Vector2 startPos;

    private Animator animator;


    /// <summary>
    /// The following are a bunch of variables to get the HP looking correct
    /// </summary>
    public Texture backgroundTexture;
    public Texture foregroundTexture;
    public Texture frameTexture;

    int healthWidth = 200;
    int healthHeight = 30;

    int healthMarginLeft = 41;
    int healthMarginTop = 38;

    int frameWidth = 266;
    int frameHeight = 65;

    int frameMarginLeft = 10;
    int frameMarginTop = 10;

	void Awake(){
		transform.position = startPos;
	}

	// Use this for initialization
	void Start () {
		//startPos = transform.position;
        animator = this.GetComponent<Animator>();
        health = gameObject.GetComponent<PlayerDamage>().health;
	}

    void OnCollisionEnter2D(Collision2D col) 
    {
		if (transform.childCount == 0) {

						if (col.transform.root.gameObject.tag == "Enemy") {
								//grab the parent objects script (chain and saw are composite objects) then get damage from them and apply it
								int damage = col.transform.root.gameObject.GetComponent<EnemyStats> ().damage;
								ApplyDamage (damage);
						}
						if (col.gameObject.tag == "consumable") {
								int healAmount = col.gameObject.GetComponent<Potion> ().healAmount;
								heal (healAmount);
								Destroy (col.gameObject);
						}
						if (col.gameObject.tag == "collectible") {
								int amount = col.gameObject.GetComponent<Collect> ().amount;
								collect (amount);
								Destroy (col.gameObject);

						}
		}
    }

	void ApplyDamage(float damage)
	{
        //reduce hp and reflect that in the GUI
		health -= damage;
        healthWidth = (int)health * 2;
        if (health <= 0) 
        {
            animator.SetInteger("Die", 1);
            gameObject.GetComponent<PlayerMovement>().enabled = false;
            GameObject cam = GameObject.FindGameObjectWithTag("MainCamera");
            if (cam) 
            {
                cam.GetComponent<FadeOut>().fade = true;
                Invoke("Reset", 3f);
            }
        }

	}

    void Reset() 
    {
		gameObject.GetComponent<PlayerMovement>().enabled = true;
		//PlayerMovement.myPlayer = null; // so the dead body stays where the player died
		Application.LoadLevel(Application.loadedLevelName);
		animator.SetInteger ("Die", 0);
		Destroy (gameObject);
    }


    void heal(float amount)
    {
        health += amount;
        if (health >= 100)
            health = 100;
        healthWidth = (int)health * 2;

    }
    void collect(int amount)
    {
		PlayerMovement.player.cash += 1;
    }

	// Update is called once per frame
	void Update () 
    {

	
	}
    void OnGUI()
    {
        //red
        GUI.DrawTexture(new Rect(frameMarginLeft, frameMarginTop, frameMarginLeft + frameWidth, frameMarginTop + frameHeight), backgroundTexture, ScaleMode.ScaleToFit, true, 0);
        //green
        GUI.DrawTexture(new Rect(healthMarginLeft, healthMarginTop, healthWidth + healthMarginLeft, healthHeight), foregroundTexture, ScaleMode.ScaleAndCrop, true, 0);
        //black
        GUI.DrawTexture(new Rect(frameMarginLeft, frameMarginTop, frameMarginLeft + frameWidth, frameMarginTop + frameHeight), frameTexture, ScaleMode.ScaleToFit, true, 0);

    }


}
