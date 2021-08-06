using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    [SerializeField] Vector3 force;
    [SerializeField] Sprite[] balloonSprites;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    private UIManager UIMgr;

    // Start is called before the first frame update
    void Start()
    {

        UIMgr = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();

        rb = GetComponent<Rigidbody2D>();

        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = balloonSprites[Random.Range(0, 77)];

        transform.position = new Vector3(Random.Range(-1f, 0.83f), transform.position.y, transform.position.z);

        force = new Vector3(Random.Range(-100, 100), Random.Range(150, 250), 0);
        rb.AddForce(force);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "TopWall")
        {
            Destroy(this.gameObject);
        }
    }


    void OnMouseDown()
    {
        StartCoroutine(PopBalloon());
        UIMgr.UpdateScore();
    }
    IEnumerator PopBalloon()
    {
        yield return new WaitForSeconds((1/2));
        Debug.Log("Destroyed!!!");
        Destroy(gameObject);
        
    }
}
