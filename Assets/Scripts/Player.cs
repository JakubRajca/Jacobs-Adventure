using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Update() {
        Vector2 inputVector = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W)){
            inputVector.y = +1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x = +1;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Tap!");
        }

        inputVector = inputVector.normalized;

        transform.position += (Vector3)inputVector;
        Debug.Log(inputVector);
    }
}