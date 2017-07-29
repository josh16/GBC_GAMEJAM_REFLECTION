using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demon : MonoBehaviour {

	public GameObject demonPrefab;
	public Transform Spawner;
	Rigidbody rb;


	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
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
		SpawnDemon ();
	}



	public void SpawnDemon()
	{

		//rb = Instantiate (demonPrefab, Spawner.transform.position, Spawner.rotation) as Rigidbody;
	}


}
