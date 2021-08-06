using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptRandom : MonoBehaviour
{
    public Image image;
    public Text obj;

    public GameObject pointingScene, pointingFill;

    public void fillPointingPage()
    {
        obj.text = image.name;
        pointingScene.SetActive(false);
        pointingFill.SetActive(true);
    }
}
