using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Scoring : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        ScoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EarnScore(int newscore)
    {
        score = score + newscore;
        ScoreText.text = "Score: " + score;
    }

}
