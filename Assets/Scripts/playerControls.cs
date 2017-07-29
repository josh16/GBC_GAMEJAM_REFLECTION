using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour {


	public Transform handTransform;
	public GameObject candleObject;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}





	public void pickUpCandle()
	{
		if (Input.GetKey(KeyCode.E)) 
		{
			if (tag == "Candle") {

				//Pick up the gameobject
				candleObject.SetActive(true);
			}

		}

	}



}
