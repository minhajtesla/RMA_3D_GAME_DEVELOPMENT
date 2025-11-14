using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateobject : MonoBehaviour
{
    public float speed = 50f;
    public Vector3 rotationAxis = new Vector3(0,0,1);

    private void Update()
    {
        transform.Rotate(rotationAxis, speed * Time.deltaTime);
    }
}
