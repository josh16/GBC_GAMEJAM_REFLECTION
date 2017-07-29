using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour {

	//Public Variables
	public float chaseSpeed;
	public float rotationSpeed;

	public Transform player;


	Animator anim;


	NavMeshAgent agent;




	void Start()
	{

		anim = GetComponent<Animator> ();

		agent = GetComponent<NavMeshAgent>();
		agent.destination = player.position;
		anim.SetBool ("isIdle", true);
	}





	void Update()
	{


	}


}




