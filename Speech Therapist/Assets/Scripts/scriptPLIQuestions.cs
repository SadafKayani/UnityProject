using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scriptPLIQuestions : MonoBehaviour
{
    public GameObject hearing, talking;
    public void hearingToTalking()
    {
        hearing.SetActive(false);
        talking.SetActive(true);
    }
    public void talkingToHearing()
    {
        talking.SetActive(false); 
        hearing.SetActive(true);
    }
}
