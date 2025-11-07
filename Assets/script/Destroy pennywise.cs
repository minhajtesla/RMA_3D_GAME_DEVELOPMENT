using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroypennywise : MonoBehaviour
{
    public GameObject pennywise;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Destroying Pennywise");
            Destroy(pennywise);
        }
    }
}
