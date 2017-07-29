using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour 
{

	//public variables


	//Transform
	public Transform audioLocation;

	//Audio Reference
	public AudioClip eerieMusic;
	public float volume = 70.0f;
	//public AudioSource source;



	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{
			//Play Audio music
			AudioSource.PlayClipAtPoint(eerieMusic, audioLocation.transform.position,volume);

		}

	}

}
