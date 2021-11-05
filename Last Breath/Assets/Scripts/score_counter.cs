using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_counter : MonoBehaviour
{
    public float score;
    public Text score_text;
    

    private void Update()
    {
        score += Time.deltaTime;
        score_text.text = "Score - " + score.ToString("F0");
        // if die then time.timescale = 0; // player.enabled = false // gameover image = true 
    }
}
