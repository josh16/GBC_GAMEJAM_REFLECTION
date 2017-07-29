	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIToggle : MonoBehaviour {


	//Public Declarations
	public GameObject deskCandle;

	playerControls playerControllerScript;



	//Private Declarations
	private bool pickCandleOn; //GUI message pops up
	//private bool deskCandleOff;




	// Update is called once per frame
	void Update () 
	{
		//candleInteraction ();

	}




	void OnTriggerEnter(Collider other)
	{
		//Once player enters trigger, UI text pops up
		if (other.gameObject.tag == "Player") 
		{
			//candleInteraction (); // Call pick up function
			pickCandleOn = true;
			playerControllerScript.pickUpCandle ();
		}
			

	}


	void OnTriggerExit(Collider other)
	{

		pickCandleOn = false;
	}


	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player") 
		{
			candleInteraction ();



			playerControllerScript.pickUpCandle ();

		}
	}



	//GUI FUNCTION
	void OnGUI()
	{
		if (pickCandleOn == true) 
		{
			if (GUI.Button ( new Rect (350, 100, 500, 40), "Press 'E' to pick up Candle")) 
			{
				Debug.Log("Message popped up!");
				pickCandleOn = false;



			}

		}


	}




	void candleInteraction()
	{
		
		if(Input.GetKey(KeyCode.E))
		{
			//Turns off candle off desk
			deskCandle.SetActive (false);

		}
	
	
	}



}
