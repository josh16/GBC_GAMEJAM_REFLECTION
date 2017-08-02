using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour {



    //Reference to Candle Script
	MirrorMessage mirrorScript;
    //Reference to Mirror Script
	Candle candleScript;


    //Bools

    bool activateCandle;

	public Transform handTransform;
	public GameObject candleObject;

    void Start()
    {
        candleObject.SetActive(false);

    }



	public void objectInteraction()
	{
        //Interaction with Candle
		if (Input.GetKey(KeyCode.E)) 
		{
			if (tag == "Candle") 
			{
                //calls candle interaction method from candle script
				candleScript.candleInteraction ();
                
                //Enable the candle on the player
				
            }

		}

		//Interaction with Mirrors
		if (Input.GetKey (KeyCode.E)) 
		{
			if (tag == "Mirror") 
			{
                //Interaction with Mirror script
                mirrorScript.mirrorInteraction();

			}
		}

	
	}


    void OnTriggerStay(Collider other)
    {
        if(activateCandle == true)
        {
            candleObject.SetActive(true);
        }

    }

    //boolean statement for activating the candle





}
