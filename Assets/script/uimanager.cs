using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class uimanager : MonoBehaviour
{
    public static uimanager instance;

    public GameObject infopanel;
    public TextMeshProUGUI infotext;

    public void Awake()
    {
        if(instance == null)
            instance = this;
        

        infopanel.gameObject.SetActive(false);
    }


    public void showmessage(string msg)
    {
        infopanel.gameObject.SetActive(true);
        infotext.text = msg;
    }
    public void hidemessage()
    {
        infopanel.gameObject.SetActive(false);
        infotext.text = "";
    }
}
