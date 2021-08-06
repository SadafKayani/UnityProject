using UnityEngine;
using System;
using System.Collections;
using UnityEngine.Networking;
using System.Collections.Generic;
using System.IO;

public class scriptLearningCategories : MonoBehaviour
{

    public GameObject muted, unmuted;
    public GameObject prev, next, previous;

    public GameObject imgAns;
    public AudioSource audAns;

    //public string microphone;
    public int audioSampleRate = 44100;
    private AudioSource audioSource;
    public void muteToUnmute() 
    {
        imgAns.SetActive(false);
        muted.SetActive(false);
        unmuted.SetActive(true);

        /*audioSource = GetComponent<AudioSource>();
        foreach (string device in Microphone.devices)
        {
            if (microphone == null)
            {
                //set default mic to first mic found.
                microphone = device;
            }
            //options.Add(device); '
        }
        //Start recording to audioclip from the mic
        audioSource.clip = Microphone.Start(null, false, 10, 44100);
        //audioSource.loop = true;
        if (Microphone.IsRecording(microphone))
        { //check that the mic is recording, otherwise you'll get stuck in an infinite loop waiting for it to start
            while (!(Microphone.GetPosition(microphone) > 0))
            {
            } // Wait until the recording has started.


            Debug.Log("recording started with " + microphone);

            // Start playing the audio source
            Debug.Log("recording");
            //audioSource.Play();
        }
        else
        {
            //microphone doesn't work for some reason

            Debug.Log(microphone + " doesn't work!");
        }*/

    }
    public void unmuteToMute()
    {
        muted.SetActive(true);
        unmuted.SetActive(false);
        imgAns.SetActive(true);
        audAns.Play();
    }

    public void nextCanvas()
    {
        imgAns.SetActive(false);
        prev.SetActive(false);
        next.SetActive(true);
    }
    public void prevCanvas()
    {
        imgAns.SetActive(false);
        prev.SetActive(false);
        previous.SetActive(true);
    }
   

}
