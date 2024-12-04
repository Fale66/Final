using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarnZone : MonoBehaviour
{
    public GameObject player;
    public Scoring Scoring;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            Scoring.EarnScore(1);
        }
    }
        
}
