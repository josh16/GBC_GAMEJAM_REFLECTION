using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demon : MonoBehaviour {


	public Transform Spawner;
	public Rigidbody DemonCreature;


	// Use this for initialization
	void Start () 
	{
		DemonCreature = GetComponent<Rigidbody> ();
	}
	


	void OnTriggerEnter(Collider other)
	{

		if (other.tag == "Player") 
		{
			SpawnDemon ();
		}
	

	}




	// Update is called once per frame
	void Update () 
	{
		
	}



	public void SpawnDemon()
	{

		Instantiate (DemonCreature, Spawner.transform.position, Spawner.rotation);
	}


}
