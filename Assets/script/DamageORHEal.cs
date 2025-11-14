using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageORHEal : MonoBehaviour
{
    public bool isdamage = true;
    public float ammount = 10f;
    public float delay = 1f;
    public float nexttime = 0f;

    public PlayerHealth playerhealth;

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player") && Time.time>nexttime)
            applyEffect();

    }

    public void applyEffect()
    {
        if ((isdamage))
        {
            playerhealth.takedamage(ammount);
        }
        else
        {
            playerhealth.Heal(ammount);
        }

        nexttime = Time.time + delay;
    }
}
