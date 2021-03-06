﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 velocity;

    //Using fixedupdate as it is the physics update.
    void FixedUpdate()
    {
        //creating a vector called prev that hold the "prev" location.
        var prev = transform.position;
        //updates the position with the velocity. 0.1f in x direction.
        transform.position = transform.position + new Vector3(0.1f, 0, 0);

        //calculates velocity from prev location to current location.
        velocity=Velocity(prev, transform.position);
    }

    //method for calculating the velocity.
    Vector3 Velocity(Vector3 prev, Vector3 current)
    {
        //returns the velocity in a vector3.
        return (current - prev);
    }
}
