using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

    public Transform _player1;
    public Transform _player2;

    private void Update()
    {
        CameraFollowPlayers(Camera.main, _player1, _player2);
    }

    //Camera follow for two players.
    public void CameraFollowPlayers(Camera cam, Transform player1, Transform player2)
    {
        //Calculate the midpoint between the two players.
        Vector3 midpoint = (player1.position + player2.position) / 2.0f;

        //Move camera away from the midpoint with distance. 
        Vector3 cameraToPoint = midpoint - cam.transform.forward * GetDistance(player1.position, player2.position);

        //Using Slerp to move camera back and forth over time 1.
        cam.transform.position = Vector3.Slerp(cam.transform.position, cameraToPoint, 1);

        //Prevent camera from moving when we are close enough. 
        if (GetDistance(cameraToPoint, cam.transform.position) <= 0.05f) cam.transform.position = cameraToPoint;
    }

    //Distance between the two players.
    float GetDistance(Vector3 point1, Vector3 point2)
    {
        //Using pythagoras theorem.
        var result = Mathf.Sqrt(Mathf.Pow((point1.x - point2.x), 2) + Mathf.Pow((point1.y - point2.y), 2) + Mathf.Pow((point1.z - point2.z), 2));
        return result;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawLine(_player1.position, _player2.position);

    }
}
