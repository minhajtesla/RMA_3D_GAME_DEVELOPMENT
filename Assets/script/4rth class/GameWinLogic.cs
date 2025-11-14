using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWinLogic : MonoBehaviour
{
    public GameObject npc;
    public GameObject particle;
    public bool isgameCOmplete = false;

    public Rigidbody rb;

    private void Start()
    {
        particle.SetActive(false);
    }
    private void Update()
    {
        if(isgameCOmplete)
        {
            particle.SetActive(true);
            npc.transform.Rotate(0, 50 * Time.deltaTime, 0);
            npc.transform.position += new Vector3(0, 2f * Time.deltaTime, 0);
            npc.transform.position -= new Vector3(0, 2f * Time.deltaTime, 0);
            // Game win logic can be handled here if needed
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isgameCOmplete)
        {
            Soundmanager.instance.PlaySound(Soundtype.gameWin);

            isgameCOmplete = true;
            Debug.Log("Game Won!");
            StartCoroutine(waitforswin());
            // Add your game win logic here (e.g., load win screen, display message, etc.)
        }
    }

    private IEnumerator waitforswin()
    {
        
        rb.AddForce(Vector3.up * 500f);
        
        yield return new WaitForSeconds(1f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameWin");
    }
}
