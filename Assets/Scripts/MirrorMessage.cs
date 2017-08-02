using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorMessage : MonoBehaviour {


	//Public Declarations
	//public GameObject redArrow;
	public GameObject theObject;


	//Private Declarartions
	private bool lookInMirror;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	/*
	//Trigger Enter Code
	void OnTriggerEnter(Collider other)
	{
		//Once player enters trigger, UI text pops up
		if (other.gameObject.tag == "Player") 
		{

			//Display Pop up message that says "Press 'E' to pick up"
			lookInMirror = true;
		}

		
	}

	*/

	//Trigger Exit Code

	void OnTriggerExit(Collider other)
	{

		lookInMirror = false;
	}



	void OnTriggerStay(Collider other)
	{


		//Red Arrow Appears
		interactMirror ();
		/*
		if (other.tag == "Player") 
		{
			//Red Arrow Appears
			interactMirror ();	

		}

		*/
	}


	//Interaction Code 
	void interactMirror()
	{

		if (Input.GetKey (KeyCode.E)) 
		{
			//Interact with the mirror and than a message behind the player appears
			theObject.SetActive(true);
		}
	}








	//GUI FUNCTION
	void OnGUI()
	{
		if (lookInMirror == true) 
		{
			if (GUI.Button ( new Rect (345, 100, 500, 40), "Look into Mirror? 'Press E'")) 
			{
				Debug.Log("Message popped up!");
				lookInMirror = false;
			}

		}


	}





}
