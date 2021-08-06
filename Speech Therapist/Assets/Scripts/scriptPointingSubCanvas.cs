using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptPointingSubCanvas : MonoBehaviour
{
    public AudioSource instruc;
    public GameObject prevCanvas;
    public GameObject nextCanvas;
    public GameObject wrong;
    public AudioSource incorrect;

    public void readInstruc()
    {
        instruc.Play();
    }

    public void switchCanvas()
    {
        prevCanvas.SetActive(false);
        nextCanvas.SetActive(true);
    }

    public void enableWrong()
    {
        wrong.SetActive(true);
        incorrect.Play();
    }
}
