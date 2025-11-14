//using System.Collections;
//using System.Collections.Generic;
//using UnityEditor.SearchService;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class Gamemanager : MonoBehaviour
//{
//    public static Gamemanager instance; 
//    public bool gamewin = false;
//    public bool gameover = false;
//    private void Awake()
//    {
//        if(instance == null)
//        {
//            instance = this;
//        }
//        else
//        {
//            Destroy(gameObject);
//        }
//    }
//    private void Update()
//    {
//        //gameoverandwineffect();
//    }
//    public void gameoverandwineffect()
//    {
//        if(gameover==true)
//        {
//            Debug.Log("Game Over!");
//            soundmanager.instance.playsound(Sound.gameover);
//            SceneManager.LoadScene("Gameover");
//        }
//        if(gamewin==true)
//        {
//            Debug.Log("Game Completed!");
//            soundmanager.instance.playsound(Sound.gamewin);
//            SceneManager.LoadScene("Gamecomplete");
//        }
//        else
//        {
//            return;
//        }
//    }

    


//}
