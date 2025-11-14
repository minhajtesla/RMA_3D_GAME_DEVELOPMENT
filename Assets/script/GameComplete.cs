using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{
    public GameObject npc;
    public GameObject particle;
    public  static bool gamecompleted = false;

    private void Update()
    {
        if(gamecompleted==true)
        {
            particle.SetActive(true);

            npc.transform.position += new Vector3(0,1,0) * Time.deltaTime;
            npc.transform.Rotate(new Vector3(0, 100, 0) * Time.deltaTime);
            npc.transform.position -= new Vector3(0, 1, 0) * Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !gamecompleted)
        {
            gamecompleted = true;
            Debug.Log("Game Completed!");
            soundmanager.instance.playsound(Sound.gamewin);
            //SceneManager.LoadScene("GameWin");
            StartCoroutine(waitforgamewin());
        }
    }

    private IEnumerator waitforgamewin()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("GameWin");
    }

}
