using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundscript : MonoBehaviour
{
    //The sound that will play when an object enters this trigger
    public AudioClip triggerSound;
    //The audio source that will play that sound
    public AudioSource source;


    private void OnTriggerEnter(Collider other)
    {
        //Tell the source to apply play sound triggerSound once
        source.PlayOneShot(triggerSound);
    }
}
