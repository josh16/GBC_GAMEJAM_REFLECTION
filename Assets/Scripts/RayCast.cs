using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour {


    public Vector3 rayOrigin;
    public float rayDistance;

    LayerMask door;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        RaycastHit hit;
        Ray lightRay = new Ray(rayOrigin, Vector3.forward);

        Physics.Raycast(lightRay, out hit, door);

    }
}
