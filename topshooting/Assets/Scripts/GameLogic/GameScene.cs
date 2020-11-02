using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScene : Singleton<GameScene>
{
    private int score;

    [SerializeField]
    private Text ScoreText;

    protected override void Awake()
    {
        base.Awake();
        score = 0;
    }

    public void AddScore(int add_Score)
    {
        score += add_Score;
        ScoreText.text = $"Score : {score}"; //'$'를 붙일 시 {} 안에 변수 추가 가능
    }
}
