using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIToggle : MonoBehaviour {




	private bool pickCandle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter(Collider other)
	{
		//Once player enters trigger, UI text pops up
		if (other.gameObject.tag == "Player") 
		{
			
			//Display Pop up message that says "Press 'E' to pick up"
			pickCandle = true;
		}





	}


	void OnTriggerExit(Collider other)
	{

		pickCandle = false;
	}


	//GUI FUNCTION
	void OnGUI()
	{
		if (pickCandle == true) 
		{
			if (GUI.Button ( new Rect (350, 100, 500, 40), "Press 'E' to pick up Candle")) 
			{
				Debug.Log("Message popped up!");
				pickCandle = false;
			}

		}


	}


}
