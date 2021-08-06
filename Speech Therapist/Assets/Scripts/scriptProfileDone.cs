using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scriptProfileDone : MonoBehaviour
{
    public Text setCFName;
    private string passedCFName;
    private scriptProfileCreation UIMgr;
    void Start()
    {
        setCFName.text = passedCFName;
    }
    public void getCFName(string savedCFName)
    {
        passedCFName = savedCFName;
    }
}
