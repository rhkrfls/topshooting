using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GameScene : Singleton<GameScene>
{
    // static public > public > private 순서로 작성
    
    public bool isPlaying { get; private set; }

    [SerializeField]
    private SpawnManager spawnManager;

    [SerializeField]
    private Player player;

    protected override void Awake()
    {
        base.Awake();
        SetPlayComponet(false);
    }

    public void StartGame()
    {
        var fireSequence = DOTween.Sequence();
        fireSequence.Append(player.transform.DOMoveY(-5.0f, 2f).SetEase(Ease.InCirc, 2f));
        fireSequence.AppendCallback(() =>
        {
            isPlaying = true;
            SetPlayComponet(true);
        });
    }

    public void GameOver()
    {
        isPlaying = false;
        SetPlayComponet(false);
    }

    private void SetPlayComponet(bool isOn)
    {
        spawnManager.enabled = isOn;
        player.enabled = isOn;
        GameHUD.Instance.gameObject.SetActive(isOn);
    }
}
