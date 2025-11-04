using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementspeed;
    public float rotationspeed;
    public float scalingspeed;


    public float horizontal;
    public float vertical;


    public Vector3 axis = new Vector3(0, 0, 0);

    private void Update()
    {
        rotate();
        scaling();
    }
    void rotate()
    {
        if (Input.GetKey(KeyCode.R))
        {
            transform.Rotate(axis * rotationspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.T))
        {
            transform.Rotate(-axis * rotationspeed * Time.deltaTime);
        }
    }

    void scaling()
    {
        if(Input.GetKey(KeyCode.S))
        {
            transform.localScale += Vector3.one * scalingspeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.localScale -= Vector3.one * scalingspeed * Time.deltaTime;
        }
    }

}
