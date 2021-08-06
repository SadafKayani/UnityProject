using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scriptGeneralRouting : MonoBehaviour
{
    public void pliResults()
    {
        SceneManager.LoadScene(12);
    }
    
    public void backP()
    {
        SceneManager.LoadScene(13);
    }
    public void next2()
    {
        SceneManager.LoadScene(44);
    }
    public void next3()
    {
        SceneManager.LoadScene(45);
    }
    public void nextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void prevScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void jumpOneScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void jumpTwoScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void jumpThreeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void jumpFourScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }
    public void jumpFiveScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }
    public void jumpSixScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }
    public void jumpSevenScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }
    public void jumpEightScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
    }
    public void jumpNineScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
    }
    public void backOneScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void backTwoScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    public void backThreeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
    public void backFourScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }
    public void backFiveScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
    }
    public void backSixScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }
    public void backSevenScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
    }
    public void backEightScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 9);
    }
    public void backNineScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 10);
    }

    public void go121()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 20);
    }
    public void go221()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 21);
    }
    public void go321()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 22);
    }
    public void gl13()
    {
        SceneManager.LoadScene(13);
    }
    public void gl21()
    {
        SceneManager.LoadScene(21);
    }
    
    public void gl43()
    {
        SceneManager.LoadScene(43);
    }
    public void gl44()
    {
        SceneManager.LoadScene(44);
    }
    public void gl45()
    {
        SceneManager.LoadScene(45);
    }
    public void gl46()
    {
        SceneManager.LoadScene(46);
    }
    public void gl47()
    {
        SceneManager.LoadScene(47);
    }
}

