using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstAcc : MonoBehaviour {
    public Vector3 prev, current;

	void Update ()
	{
        prev = transform.position;
        //adding a vector to the current position. The added vector has a value of 0.1 in the z component.
        current = transform.position = transform.position + new Vector3(0, 0, 0.1f);

	}
}
