using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DolphinAudioController : MonoBehaviour {
    public AudioSource audioSource;

    public void playSoundOnPress() {
        audioSource.Play();
    }


}