using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pool : MonoBehaviour {

	public static Pool current;
	public GameObject pooledObject;
	public int pooledAmount = 20;
	public bool willGrow = true; //asks if you want to make the pool expandable.  Will not shrink.

	List<GameObject> pooledObjects;

	void Awake()
	{
		current = this;
	}

	void Start() {

		pooledObjects = new List<GameObject> ();

		//pools the objects
		for (int i =0; i < pooledAmount; i++) {
			
			GameObject obj = (GameObject)Instantiate(pooledObject);
			obj.SetActive(false);
			pooledObjects.Add(obj);
		}
		
	}
	
	public GameObject GetPooledObjects()
	{
		for (int i = 0; i < pooledObjects.Count; i++) 
		{
			if(!pooledObjects[i].activeInHierarchy)
				return pooledObjects[i];
		}
		if(willGrow)
		{
			GameObject obj = (GameObject)Instantiate(pooledObject);
			pooledObjects.Add(obj);
			return obj;
		}
		return null;
	}
	
}
