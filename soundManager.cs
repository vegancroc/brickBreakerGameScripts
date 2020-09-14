using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class soundManager : MonoBehaviour
{
    AudioSource audio;
    public AudioClip[] AudioClips;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    #region Sounds
    public void PlayBallHittingSound(float volume) //Vuruş efekti..
    {
        audio.PlayOneShot(AudioClips[0]);
    }

    public void PlayBackGround()  //Arkaplan sesi..
    {
        audio.PlayOneShot(AudioClips[1]);
    }

    public void PlayHurtSound(float volume) //Can yakma sesi..
    {
        audio.PlayOneShot(AudioClips[2],volume);
    }

    public void PlayMetalHitSound(float volume)
    {
        audio.PlayOneShot(AudioClips[3], volume);
    }

    public void volumeDown()  //Sesi kıs..
    {
        audio.volume = 0f;
    }

    
    #endregion
}
