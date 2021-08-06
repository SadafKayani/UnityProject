using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    //int score = 0;
    [SerializeField] Text scoreText;

    public GameObject idCompleteUI, current;

    public void UpdateScore()
    {
        scoreText.text = (int.Parse(scoreText.text) + 1).ToString();
        if (int.Parse(scoreText.text) == 10)
        {
            //Time.timeScale = 0f;
            current.SetActive(false);
            idCompleteUI.SetActive(true);
        }

    }
}
