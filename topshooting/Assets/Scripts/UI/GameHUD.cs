using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHUD : Singleton<GameHUD>
{
    private int score;
    private Text ScoreText;

    protected override void Awake()
    {
        base.Awake();
        score = 0;

        foreach (Transform child in transform.GetComponentInChildren<Transform>(true))
        {
            if(child.gameObject.name == "ScoreText")
            {
                ScoreText = child.gameObject.GetComponent<Text>();
                break;
            }
        }
    }

    public void AddScore(int add_Score)
    {
        score += add_Score;
        ScoreText.text = $"Score : {score}"; //'$'를 붙일 시 {} 안에 변수 추가 가능
    }
}
