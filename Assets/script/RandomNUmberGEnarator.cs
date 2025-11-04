using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomNUmberGEnarator : MonoBehaviour
{
    public int number;
    public string playerName;
    public TMP_Text text;

    public bool ischeating = false;
    private void Start()
    {
        text.text = "enter the button to generate random number";   
    }

    public void generatefunction()
    {

        number = Random.Range(0, 100);

        if (ischeating)
        {
            number = 300;
        }

        text.text = playerName + " your random number is " + number.ToString();


    }
}
