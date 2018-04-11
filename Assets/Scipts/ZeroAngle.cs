using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class ZeroAngle : MonoBehaviour
{
    private float time, zeroAngleLeft, zeroAngleRight;
    private Vector3 origin = Vector3.zero;

    public Transform trackableLeft, trackableRight;
    public Vector3 zeroVectorLeft = Vector3.zero, zeroVectorRight = Vector3.zero;
    public float angleLeft, angleRight;

    // Use this for initialization
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Updating the origin of the object, and normalizing it.
        origin = transform.position.normalized;

        //If statement to start calibration of the zero vectors for the left and right trackable.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            zeroVectorLeft = Calibrate(trackableLeft.position, origin);
            zeroVectorRight = Calibrate(trackableRight.position, origin);
        }

        //Calculating the left and right angle between the calibrated zero vector and the vector for the origin to the trackable object
        angleLeft = GetAngle(trackableLeft.position.normalized - origin, zeroVectorLeft-origin);
        angleRight = GetAngle(trackableRight.position.normalized - origin, zeroVectorRight-origin);
    }

    //Method for calibrating the zero vector
    Vector3 Calibrate(Vector3 vector, Vector3 vector2)
    {
        //Initializing 3 list for the xyz values of the vector between the origin and the trackable object.
     var currentVectorX = new List<float>();
     var currentVectorY = new List<float>();
     var currentVectorZ = new List<float>();

        //while loop for the calibration for 5 seconds.
        while (time < 5.0f)
        {
            //Calculate the vector from origin to the trackable object and add the xyz values to the lists..
            var currentVector = vector-vector2;
            currentVectorX.Add(currentVector.x);
            currentVectorY.Add(currentVector.y);
            currentVectorZ.Add(currentVector.z);
            //incrementing the time.
            time += Time.deltaTime;
        }
        time = 0;
        //taking the average of the xyz components to create a new vector that is the average vector.
        Vector3 returnVector = new Vector3(currentVectorX.Average(), currentVectorY.Average(), currentVectorZ.Average()); 
        return returnVector;
    }

    //Method for calculating the angle between two vectors.
    float GetAngle(Vector3 vector1, Vector3 vector2)
    {
        //Using the the dot product between two normalized vector to get the cosine to the angle. 
        //Then taking the arc cos to that value, to the get the angle in rads
        var angle = Mathf.Acos(Vector3.Dot(vector1.normalized, vector2.normalized));
        //returning the angle in degrees.
        return Mathf.Rad2Deg*angle;
    }
    //To draw lines in the editor.
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(trackableLeft.position, origin);
        Gizmos.DrawLine(trackableRight.position, origin);
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(origin, Vector3.left*10);
        Gizmos.DrawLine(origin, Vector3.right*10);
        Gizmos.color = Color.red;
        Gizmos.DrawLine(zeroVectorLeft, origin);
        Gizmos.DrawLine(zeroVectorRight, origin);
    }
}
