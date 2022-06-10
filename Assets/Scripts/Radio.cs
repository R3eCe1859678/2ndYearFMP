using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioSource audiobgGameMusic;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerMovement player))
        {
            audiosource.mute = false;


            // stop menu music
            StartCoroutine(AudioFadeScript.FadeOut(audiobgGameMusic, 0f));




        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out PlayerMovement player))
        {
            audiosource.mute = true;

            
            // start game music
            StartCoroutine(AudioFadeScript.FadeIn(audiobgGameMusic, 1f));
        }
    }


}
