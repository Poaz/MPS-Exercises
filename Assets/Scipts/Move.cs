using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 velocity;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var prev = transform.position;
        transform.position = transform.position + new Vector3(0.1f, 0, 0);

        velocity=Velocity(prev, transform.position);
    }

    Vector3 Velocity(Vector3 prev, Vector3 current)
    {
        return current - prev;
    }
}
