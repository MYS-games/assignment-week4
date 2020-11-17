using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    public NumberField score;
    int currScore = 0;
    // Start is called before the first frame update

    public void addPointToScore()
    {
        currScore = score.GetNumber();
        currScore++;
        score.SetNumber(currScore);
    }
}
