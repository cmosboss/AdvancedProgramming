using UnityEngine;
using System.Collections;

public class ConcreteObserver : Handler
{
	public int ObsTracker{ get; set; }
	public int TypeOfSignal{ get; set; }
	public float EnemyCoordX{ get; set; }
	public float EnemyCoordY{ get; set; }

		// Use this for initialization
		void Start ()
		{
		    //ObsTracker = Handler.UpdateObserverNum ();
		    //Handler.Attach (this);
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		public ConcreteObserver(int Type, float X, float Y)
		{
			TypeOfSignal = Type;
			EnemyCoordX = X;
			EnemyCoordY = Y;
		}
	
		public void Receive()
		{
		//Start Tracking Player
		}

		public void Notify()
		{
		//Use when hit, Start Tracking
		//Handler.SendSignal();
		}
}

