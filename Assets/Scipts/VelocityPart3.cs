using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityPart3 : MonoBehaviour {

    public Vector3 velocity1, velocity2;
    public RandomAcc sphere1;
    public ConstAcc sphere2;

    //Using fixedupdate as it is the physics update.
    void FixedUpdate()
    {
        //calculates velocity from prev location to current location.
        velocity1 = Velocity(sphere1.prev, sphere1.current);
        velocity2 = Velocity(sphere2.prev, sphere2.current);
    }

    //method for calculating the velocity.
    Vector3 Velocity(Vector3 prev, Vector3 current)
    {
        //returns the velocity in a vector3.
        return (current - prev);
    }
}
