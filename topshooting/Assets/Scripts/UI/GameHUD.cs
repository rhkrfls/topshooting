using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHUD : UI<GameHUD>
{
    private int score;

    public void AddScore(int add_Score)
    {
        score += add_Score;
        Vars["ScoreText"].GetComponent<Text>().text = $"Score : {score}";
    }
}
