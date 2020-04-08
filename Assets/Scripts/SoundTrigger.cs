using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]             //Forces an AudioSource to be required by prefab this script is attached to.
public class SoundTrigger : MonoBehaviour
{
    AudioSource SoundToPlay;            //Sound To Play on Trigger Event.

    [Tooltip("Set the time to delay before start playing sound after Trigger Event")]
    public float TimeBeforeStartPlaying = 0;    //Sets the delay to play clip after trigger event.
    
    // Start is called before the first frame update
    void Start()
    {
        SoundToPlay = GetComponent<AudioSource>();             //Assigns AudioSource to SoundToPlay
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag== "Player")                           // Plays the sound when Trigger Event happens  only
        {
            SoundToPlay.PlayDelayed(TimeBeforeStartPlaying);        //if the other object has the Tag "Player".
        }
    }
}
