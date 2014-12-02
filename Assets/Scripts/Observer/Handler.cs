using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Handler : MonoBehaviour
{

	public int MaxNumOfObservers{ get; set;}
	public int TypeOfSignal{ get; set; }
	public List<Handler> handlers = new List<Handler>();
	public int FiredShots{ get; set; }
	public int EnemiesKilled{ get; set; }

	

		// Use this for initialization
		void Start ()
		{
		MaxNumOfObservers = 0;
		FiredShots = 0;
		EnemiesKilled = 0;
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		public void Attach(ConcreteObserver observer)
		{
		handlers.Add(observer);
		}
	
		public void Detach(ConcreteObserver observer)
		{
		handlers.Remove(observer);
		}
	//depending on the type of notification, there will be different ways of handling it, this is addressed here
		public void HandleSignal(ConcreteObserver Obs)
		{
		if (Obs.TypeOfSignal == 0) {
		
			int tempX = Obs.EnemyCoordX;
			int tempY = Obs.EnemyCoordY;
		} 
		else if (Obs.TypeOfSignal == 1) {

			FiredShots++;

		}

		else if (Obs.TypeOfSignal == 2) {

			EnemiesKilled++;
		}

		}
	//in case of emergency method, This can be filled later as a safeguard to change a single observer
		public void ResetSignal()
		{

		}
	//Upon Notification, this method is called to relay out to each and every observer
		 public void SendSignal()
		{
		foreach (Handler o in handlers)

			{
				HandleSignal(o);
			}
		}
	//This is a number in place in case I need to track a specific clone
	public int UpdateObserverNum(){

		int temp = MaxNumOfObservers;
		MaxNumOfObservers++;
		return temp;

		}
}

