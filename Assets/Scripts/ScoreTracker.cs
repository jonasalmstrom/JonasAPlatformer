using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //<- "namespace"


public class ScoreTracker : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public int totalScore;

    private void Update()
    {
        //detta gör så att den uppdaterar scoretexten hela tiden så att den skriver ut det rätta värdet av variabeln "totalScore"
        scoreText.text = string.Format("Score: {0}/10", totalScore);
    }
}
