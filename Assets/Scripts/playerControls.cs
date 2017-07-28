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
		KeyboardControls ();		
	}



	void KeyboardControls()
	{
		if (Input.GetKey(KeyCode.E)) 
		{
			//Pick up the gameobject
			candleObject.SetActive(false);
			//GameObject get's attached to player's transform
			//The GameObject becomes 'Visible'
		}

	}



}
