using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour {



    //Reference to Candle Script
	MirrorMessage mirrorScript;

	//Reference to Mirror Script
	Candle candleScript;  




	public Transform handTransform;
	public GameObject candleObject;





	public void objectInteraction()
	{


	
		//Interaction with Candle
		if (Input.GetKey(KeyCode.E)) 
		{
			if (tag == "Candle") 
			{

				//calls candle script to turn off candle
				candleScript.candleInteraction ();


				//Enable the candle on the player
				candleObject.SetActive(true);

			}

		}

		//Interaction with Mirrors
		if (Input.GetKey (KeyCode.E)) 
		{
			if (tag == "Mirror") 
			{
				/*Interact with the 'Mirror script' and access the
				 function in that class 
				*/

			}
		}

	
	}








}
