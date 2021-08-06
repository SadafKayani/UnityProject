using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class scriptDrop : MonoBehaviour, IDropHandler
{
    public GameObject tick;
    public Text score;
    public AudioSource correct;
    public GameObject prev, next;

    IEnumerator WaitBeforeSwitch()
    {
        tick.SetActive(true);
        correct.Play();
        score.text = (int.Parse(score.text) + 1).ToString();
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
