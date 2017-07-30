using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour {


	public string levelName;

	// Use this for initialization
	void Start () 
	{
		
	}




	void OnTriggerEnter(Collider other)
	{


		if (other.tag == "Player") 
		{
			Application.LoadLevel (levelName);
		}


	}



	// Update is called once per frame
	void Update () {
		
	}
}
