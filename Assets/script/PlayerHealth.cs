using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float maxhealth = 100f;
    public float currenthealth;//present health
    public Healthbar healthbar;
    public bool isdead = false;

    public Rigidbody rb;
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
            soundmanager.instance.playsound(Sound.gameover);
            Debug.Log("Player is dead");
            isdead = true;
             StartCoroutine(Gameover());

        }
        else
        {
            soundmanager.instance.playsound(Sound.hurt);
            Debug.Log("Player took damage, current health: " + currenthealth);

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

    private IEnumerator Gameover()
    {
        rb.freezeRotation = false;
        rb.AddForce(Vector3.up * 50f, ForceMode.Impulse);
        rb.AddTorque(new Vector3(0, 0, 10f), ForceMode.Impulse);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Gameover");
    }
}
