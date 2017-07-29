using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}




	void OnTriggerEnter(Collider other)
	{


		if (other.tag == "Player") 
		{
			Application.LoadLevel ("Level_2");
		}


	}



	// Update is called once per frame
	void Update () {
		
	}
}
