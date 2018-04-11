using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMove : MonoBehaviour {
	
	void Update () {
        //Checks if it is player 1 or 2
        if (gameObject.CompareTag("player1"))
        {
            //A key pressed, move left
            if (Input.GetKey(KeyCode.A)) transform.position = transform.position + new Vector3(-0.01f,0,0);
            //D key pressed, move right
            if (Input.GetKey(KeyCode.D)) transform.position = transform.position + new Vector3(0.01f, 0, 0);
        }
        //Checks if it is player 1 or 2
        if (gameObject.CompareTag("player2"))
        {   //H key pressed, move left
            if (Input.GetKey(KeyCode.H)) transform.position = transform.position + new Vector3(-0.01f, 0, 0);
            //K key pressed, move right
            if (Input.GetKey(KeyCode.K)) transform.position = transform.position + new Vector3(0.01f, 0, 0);
        }
    }
}
