using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	public Transform projectile;
	public Transform[] specials;

	public Texture2D cursorTexture;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;
	public bool firstLevel; //used to determine if we need to instantiate a concrete player.

	public Rect windowRect = new Rect(20, 20, 120, 50);

	public static PlayerComponent player;
	
	private Animator animator;

	// Use this for initialization
	void Start()
	{
		animator = this.GetComponent<Animator>();
		animator.SetInteger ("Direction", 4);
		//sets the cursor
		Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
		if (firstLevel)
			player = new ConcretePlayer();
	}

	void FixedUpdate () 
	{
		rigidbody2D.angularVelocity = 0; //prevents sliding

		float vertInput = Input.GetAxis ("Vertical");
		float horizInput = Input.GetAxis ("Horizontal");

		rigidbody2D.AddForce (gameObject.transform.up * speed * vertInput);
		rigidbody2D.AddForce (gameObject.transform.right * speed * horizInput);

		handleAnimation (vertInput, horizInput);

		handleShooting ();
	}
	/// <summary>
	/// Handles the animation.
	/// </summary>
	/// <param name="vertInput">Vert input.</param>
	/// <param name="horizInput">Horiz input.</param>
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
	/// <summary>
	/// Handles the shooting.
	/// </summary>
	void handleShooting()
	{
		if (Input.GetButtonDown ("Fire1")) 
			player.Fire (transform, projectile);

		else if (Input.GetButtonDown ("Fire2") && player.numSpecials > 0)
			player.Special (transform, specials);

	}
	/// <summary>
	/// Raises the mouse enter event.
	/// </summary>
	void OnMouseEnter () {
		Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
	}
	/// <summary>
	/// Raises the mouse exit event.
	/// </summary>
	void OnMouseExit () {
		Cursor.SetCursor(null, Vector2.zero, cursorMode);
	}	

	//-----------------------------------
	//Functions to add items and specials with decorator
	//-----------------------------------

	/// <summary>
	/// Adds the log.
	/// </summary>
	public void addLog(){
		player = new Log (player);
	}
	/// <summary>
	/// Adds the money bag.
	/// </summary>
	public void addMoneyBag(){
		player = new MoneyBag (player);
	}
	/// <summary>
	/// Adds the shield.
	/// </summary>
	public void addShield(){
		player = new Shield (player);
	}
	/// <summary>
	/// Adds the boots.
	/// </summary>
	public void addBoots(){
		player = new Boots (player);
	}
	/// <summary>
	/// Adds the mystery box.
	/// </summary>
	public void addMysteryBox(){
		player = new MysteryBox (player);
	}
	/// <summary>
	/// Adds the fire arrow.
	/// </summary>
	public void addFireArrow(){
		player = new FireArrow (player);
	}
	/// <summary>
	/// Adds the spikey ball.
	/// </summary>
	public void addSpikeyBall(){
		player = new SpikeyBall (player);
	}
	/// <summary>
	/// Adds the pizza.
	/// </summary>
	public void addPizza(){
		player = new Pizza (player);
	}
	/// <summary>
	/// Adds the da bomb.
	/// </summary>
	public void addDaBomb(){
		player = new DaBomb (player);
	}
	/// <summary>
	/// Adds the bubble.
	/// </summary>
	public void addBubble(){
		player = new Bubble (player);
	}
	/// <summary>
	/// Adds the candy.
	/// </summary>
	public void addCandy(){
		player = new Candy (player);
	}
}
