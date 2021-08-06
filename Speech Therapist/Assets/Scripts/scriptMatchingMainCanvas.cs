using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scriptMatchingMainCanvas : MonoBehaviour
{
    public GameObject prev;
    public Text num;
    public Text score;
    void Start()
    {
        prev.SetActive(false);
        score.text = num.text;
    }

    public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
