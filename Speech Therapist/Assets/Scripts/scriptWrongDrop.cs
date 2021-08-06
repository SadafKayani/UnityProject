using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class scriptWrongDrop : MonoBehaviour, IDropHandler
{
    public GameObject cross;
    public AudioSource incorrect;
    public GameObject prev, next;

   
    IEnumerator WaitBeforeSwitch()
    {
        cross.SetActive(true);
        incorrect.Play();
        yield return new WaitForSeconds(1);
        prev.SetActive(false);
        next.SetActive(true);
    }
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            StartCoroutine(WaitBeforeSwitch());
            
        }
    }
}
