using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAcc : MonoBehaviour {
    public Vector3 prev, current;

	void Update ()
    {
        prev = transform.position;
        //adding a vector to the current position. The added vector has a random value in the z component.
        current = transform.position = transform.position + new Vector3(0, 0, Random.Range(0, 0.3f));
    }
}
