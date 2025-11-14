using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missionStart : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            uimanager.instance.showmessage("find the npc. carefull of traps");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            uimanager.instance.hidemessage();
        }
    }
}
