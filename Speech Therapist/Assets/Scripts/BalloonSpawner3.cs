using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BalloonSpawner3 : MonoBehaviour
{
    [SerializeField] GameObject bubblePrefab;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0.0f, 1.0f);
        
    }

    void Spawn()
    {
        Instantiate(bubblePrefab, transform.position, transform.rotation);
    }
}
