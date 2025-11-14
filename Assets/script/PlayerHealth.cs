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
        
        if (currenthealth <=0f && !isdead)
        {
            //game over
            //death
            Soundmanager.instance.PlaySound(Soundtype.gameover);
            Debug.Log("Player is dead");
            isdead = true;
            
            StartCoroutine(waitfordeath());
        }
        else
        {
            Soundmanager.instance.PlaySound(Soundtype.Hurt);
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
        else
            Soundmanager.instance.PlaySound(Soundtype.Heal);
        healthbar.Setvalue(currenthealth);
        Debug.Log("Player healed, current health: " + currenthealth);
    }

    private IEnumerator waitfordeath()
    {
        rb.freezeRotation = false;
        rb.AddForce(Vector3.up * 500f);
        rb.AddTorque(new Vector3(100f, 0f, 0f));
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Gameover");
    }
}
