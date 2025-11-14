using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebetweenpoint : MonoBehaviour
{
    public Transform point1;
    public Transform point2;
    public float speed = 2f;

    public Vector3 target;

    private void Start()
    {
        target = point2.position;
    }

    private void Update()
    {
        if(Vector3.Distance(transform.position, target) < 0.1f)
        {
            target = (target == point1.position) ? point2.position : point1.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);   
    }
}
