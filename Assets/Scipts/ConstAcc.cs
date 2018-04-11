using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstAcc : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
	    //adding a vector to the current position. The added vector has a value of 0.1 in the z component.
        transform.position = transform.position + new Vector3(0, 0, 0.1f);

	}
}
