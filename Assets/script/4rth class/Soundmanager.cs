using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Soundtype
{
    Hurt,
    Heal,
    gameover,   
    gameWin,
    Jump,
    Wow,
}
[System.Serializable]
public class sound
{
    public Soundtype soundtype;
    public AudioClip audioClip;
}

public class Soundmanager : MonoBehaviour
{
    public static Soundmanager instance;

    public AudioSource audioSource; 

    public List<sound> sounds = new List<sound>();
    Dictionary<Soundtype, AudioClip> soundDictionary = new Dictionary<Soundtype, AudioClip>();


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        soundDictionary = new Dictionary<Soundtype, AudioClip>();   
        foreach(var sound in sounds)
        {
            soundDictionary[sound.soundtype] = sound.audioClip;
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            PlaySound(Soundtype.Wow);
        }
    }

    public void PlaySound(Soundtype soundtype)
    {
        audioSource.PlayOneShot(soundDictionary[soundtype]);
    }
}
