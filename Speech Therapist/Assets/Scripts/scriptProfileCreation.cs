using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scriptProfileCreation : MonoBehaviour
{
    public InputField uName;
    public InputField cfName;
    public Dropdown ageRange;
    public GameObject errUName;
    public GameObject errCFName;
    public GameObject errCharacters;
    public GameObject errAgeRange;

    public void profileCompletion()
    {
        if (uName.text.Equals("") && cfName.text.Equals("") && ageRange.options[ageRange.value].text.Equals("Age Range"))
        {
            errCharacters.SetActive(false);
            errUName.SetActive(true);
            errCFName.SetActive(true);
            errAgeRange.SetActive(true);
        }
        else if (uName.text.Equals("") && cfName.text.Equals(""))
        {
            errCharacters.SetActive(false);
            errAgeRange.SetActive(false);
            errCFName.SetActive(true);
            errUName.SetActive(true);
        }
        else if (cfName.text.Equals("") && ageRange.options[ageRange.value].text.Equals("Age Range"))
        {
            errCharacters.SetActive(false);
            errUName.SetActive(false);
            errCFName.SetActive(true);
            errAgeRange.SetActive(true);
        }
        else if (uName.text.Equals("") && ageRange.options[ageRange.value].text.Equals("Age Range"))
        {
            enableCharactersError();
            errCFName.SetActive(false);
            errUName.SetActive(true);
            errAgeRange.SetActive(true);
        }
        else if (uName.text.Equals(""))
        {
            enableCharactersError();
            errUName.SetActive(true);
            errCFName.SetActive(false);
            errAgeRange.SetActive(false);
        }
        else if (cfName.text.Equals(""))
        {
            errCharacters.SetActive(false);
            errUName.SetActive(false);
            errCFName.SetActive(true);
            errAgeRange.SetActive(false);
        }
        else if (ageRange.options[ageRange.value].text.Equals("Age Range"))
        {
            enableCharactersError();
            errUName.SetActive(false);
            errCFName.SetActive(false);
            errAgeRange.SetActive(true);
        }
        else
        {
            if (cfName.text.Contains("0") || cfName.text.Contains("1") || cfName.text.Contains("2") || cfName.text.Contains("3")
                || cfName.text.Contains("4") || cfName.text.Contains("5") || cfName.text.Contains("6") || cfName.text.Contains("7")
                || cfName.text.Contains("8") || cfName.text.Contains("9") || cfName.text.Contains("!") || cfName.text.Contains("@")
                 || cfName.text.Contains(".") || cfName.text.Contains(","))
            {
                errCharacters.SetActive(true);
                errUName.SetActive(false);
                errCFName.SetActive(false);
                errAgeRange.SetActive(false);
            }
            else
            {
                errUName.SetActive(false);
                errCFName.SetActive(false);
                errAgeRange.SetActive(false);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }

    }

    public void enableCharactersError()
    {
        if (cfName.text.Contains("0") || cfName.text.Contains("1") || cfName.text.Contains("2") || cfName.text.Contains("3")
                || cfName.text.Contains("4") || cfName.text.Contains("5") || cfName.text.Contains("6") || cfName.text.Contains("7")
                || cfName.text.Contains("8") || cfName.text.Contains("9") || cfName.text.Contains("!") || cfName.text.Contains("@")
                 || cfName.text.Contains(".") || cfName.text.Contains(","))
        {
            errCharacters.SetActive(true);
        }
    }

    /*public void passCFName(string savedCFName)
    {
        UIMgr.getCFName(savedCFName);
    }*/
}
