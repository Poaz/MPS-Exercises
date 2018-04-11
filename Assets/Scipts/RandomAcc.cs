using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAcc : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //adding a vector to the current position. The added vector has a random value in the z component.
	    transform.position = transform.position + new Vector3(0, 0, Random.Range(0, 0.3f));
    }
}
