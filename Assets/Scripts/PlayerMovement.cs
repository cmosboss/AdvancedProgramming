using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	public Transform projectile;
	public Transform[] specials;
	private Animator animator;

	public Texture2D cursorTexture;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;

	public static PlayerComponent player;

	public static int maxHealth = 100;
	public static int health = 100;
	public static int cash = 0;
	public static int damage = 10;
	//public static int speed = 10;
	public static int range = 10;
	public static int armour = 0;

	// Use this for initialization
	void Start()
	{
		animator = this.GetComponent<Animator>();
		animator.SetInteger ("Direction", 4);
		//sets the cursor
		Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
		player = new ConcretePlayer();
		//same as player = new ConcretePlayer(); but since PlayerComponent inherates from MonoBehaviour(So I can assign public gamobjects 
		//in the inspector) I had to do it this way.
		//player = gameObject.AddComponent ("ConcretePlayer") as ConcretePlayer;
		//player = gameObject.AddComponent<DaBomb>() as DaBomb;
		//maxHealth = player.maxHealth;
	
	}
		
	void FixedUpdate () 
	{
		/*
		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);//float;
		Quaternion rot = Quaternion.LookRotation (transform.position - mousePosition,Vector3.forward);
		transform.rotation = rot; //sets rotation of player to look at mouse
		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z); //so it only rotates on Z-axis
		*///using this code would make the controls like hotline miami, doesnt work at all with the current animation tho

		rigidbody2D.angularVelocity = 0; //prevents sliding

		float vertInput = Input.GetAxis ("Vertical");
		float horizInput = Input.GetAxis ("Horizontal");

		rigidbody2D.AddForce (gameObject.transform.up * speed * vertInput);
		rigidbody2D.AddForce (gameObject.transform.right * speed * horizInput);

		handleAnimation (vertInput, horizInput);

		handleShooting ();

	}

	void handleAnimation(float vertInput, float horizInput)
	{
		if (vertInput > 0)
		{
			animator.SetInteger("Direction", 2);
		}
		else if (vertInput < 0)
		{
			animator.SetInteger("Direction", 0);
		}
		else if (horizInput > 0)
		{
			animator.SetInteger("Direction", 3);
		}
		else if (horizInput < 0)
		{
			animator.SetInteger("Direction", 1);
		}
		else if (horizInput == 0 && vertInput == 0)
		{
			animator.SetInteger ("Direction", 4);
		}
	}

	void handleShooting()
	{

		if (Input.GetButtonDown ("Fire1")) 
			player.Fire (transform, projectile);

		else if (Input.GetButtonDown ("Fire2"))
			player.Special ();

	}

	void OnMouseEnter () {
		Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
	}
	
	void OnMouseExit () {
		Cursor.SetCursor(null, Vector2.zero, cursorMode);
	}	
}
