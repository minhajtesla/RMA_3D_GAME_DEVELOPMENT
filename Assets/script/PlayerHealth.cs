using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxhealth = 100f;
    public float currenthealth;//present health
    public Healthbar healthbar;
    public bool isdead = false;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            takedamage(20f);
        }
        if(Input.GetKeyDown(KeyCode.H))
        {
            Heal(15f);
        }
    }

    public void takedamage(float damage)
    {
        currenthealth -= damage;
        healthbar.Setvalue(currenthealth);
        
        if (currenthealth <=0f || isdead)
        {
            //gameover
            Debug.Log("Player is dead");
            //sound effect can be played here
        }
        else
        {
            Debug.Log("Player took damage, current health: " + currenthealth);
            //souond effect can be played here
        }
    }

    public void Heal(float healammount)
    {
        
        currenthealth += healammount;
        if(currenthealth > maxhealth)
        {
            currenthealth = maxhealth;
        }
        healthbar.Setvalue(currenthealth);
        Debug.Log("Player healed, current health: " + currenthealth);
    }
}
