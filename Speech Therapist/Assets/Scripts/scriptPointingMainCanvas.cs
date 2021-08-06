using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scriptPointingMainCanvas : MonoBehaviour
{
    public GameObject img;
    public GameObject btn;
    public GameObject canvas;
    public GameObject time;
    public GameObject sec;
    public Text seconds;
    public GameObject prev;
    public Text totTime;

    public int begin = 0;
    public void switchToPointing()
    {
        img.SetActive(false);
        btn.SetActive(false);
        canvas.SetActive(true);
       // time.SetActive(true);
       // sec.SetActive(true);
    }

    public void prevDisable()
    {
        prev.SetActive(false);

    }

    public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void calTotTime()
    {
        totTime.text = (((int)(Time.timeSinceLevelLoad) % 60) - begin).ToString() + " Seconds";
    }

    public void beginTimer()
    {
        begin = (int)(Time.timeSinceLevelLoad % 60);
    }

    void Update()
    {
        seconds.text = (((int)(Time.timeSinceLevelLoad) % 60) - begin).ToString() + " Seconds";

    }

}
