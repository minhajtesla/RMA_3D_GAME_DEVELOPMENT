using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Sound
{
    heal,
    hurt,
    gameover,
    gamewin,
    jump,
    wow,
}
[System.Serializable]
public class SoundAudioClip
{
    public Sound sound;
    public AudioClip audioClip;
}

public class soundmanager : MonoBehaviour
{
    public static soundmanager instance;
    public AudioSource audioSource;

    public List<SoundAudioClip> soundAudioClipList;//onek golo soundclip nibo
    private Dictionary<Sound, AudioClip> soundAudioClipDict;//tarpor ekta dictionary te rakhbo

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }

        soundAudioClipDict = new Dictionary<Sound, AudioClip>();
        foreach(SoundAudioClip sac in soundAudioClipList)
        {
            soundAudioClipDict[sac.sound] = sac.audioClip;
        }
    }

    public void playsound(Sound soundname)
    {
        if(soundAudioClipDict.ContainsKey(soundname))
        {
            audioSource.PlayOneShot(soundAudioClipDict[soundname]);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            playsound(Sound.wow);
        }
    }
}
