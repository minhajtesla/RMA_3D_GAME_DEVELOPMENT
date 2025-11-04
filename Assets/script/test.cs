using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public string name;
    public float age;
    public int money;
    public bool ispoor;
    public string qutes;// oder legendary 

    void Start()
    {
        //Debug.Log("Hello World called from start");

        printmessage(qutes);
        Debug.Log($"My name is {name}, I am {age} years old, I have {money} dollars, and it is {ispoor} that I am poor.");
    }


    public void printmessage(string qutes)
    {
        Debug.Log(qutes);
    }

    private void Update()
    {
        //Debug.Log("Hello World called from update");
    }
}
