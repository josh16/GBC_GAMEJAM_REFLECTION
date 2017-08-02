	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour {


	//Public Declarations
	public GameObject deskCandle;

	playerControls playerControllerScript;



	//Private Declarations
	private bool pickCandleOn; //GUI message pops up






	//****TRIGGER ENTER EVENTS****
	void OnTriggerEnter(Collider other)
	{
		//Once player enters trigger, UI text pops up
		if (other.gameObject.tag == "Player") 
		{
			//Calls GUI TEXT BOX function
			pickCandleOn = true;

		}
			

	}




	//*****TRIGGER EXIT EVENTS****
	void OnTriggerExit(Collider other)
	{

		pickCandleOn = false;
	}


	void OnTriggerStay(Collider other)
	{
		if (other.tag == "Player") 
		{
			candleInteraction ();



		}
	}



	//FUNCTIONS/METHODS

	public void candleInteraction()
	{

		if(Input.GetKey(KeyCode.E))
		{
			//Turns off candle off desk
			deskCandle.SetActive (false);


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






}
