using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopIFelse : MonoBehaviour
{
    public int number = 10;


    private void Start()
    {
        for(int i = 0;i<number;i++)
        {
            if (i == 2) continue;


            if(i == 5) break;
            print(i);
        }
    }
}
