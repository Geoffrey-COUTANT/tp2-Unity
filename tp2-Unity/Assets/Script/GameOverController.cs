using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public UnityEngine.UI.Button RetryButton;
    public UnityEngine.UI.Button StartGameButton;
    public UnityEngine.UI.Button ReturnMenuButton;
    public UnityEngine.UI.Button QuitButton;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI TimeText;
    
    void Start()
    {
        if (RetryButton) RetryButton.onClick.AddListener(SceneGame);
        if (ReturnMenuButton) ReturnMenuButton.onClick.AddListener(ReturnMenu);
        if (QuitButton) QuitButton.onClick.AddListener(() =>
        {
            Application.Quit();
        });
        if (StartGameButton) StartGameButton.onClick.AddListener(SceneGame);

        ScoreText.text = $"Your score is {FindObjectOfType<Score>().ScoreValue}";
        TimeText.text = $"Your time is {FindObjectOfType<Timer>().TimeCount} seconds";
    }

    void SceneGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    void ReturnMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}