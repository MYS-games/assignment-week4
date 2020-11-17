using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    int score = 0;
    // Start is called before the first frame update

    public void addPointToScore()
    {
        score = int.Parse(scoreText.text);
        score++;
        scoreText.SetText(score.ToString());
    }
}
