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
    
    void Start()
    {
        if (RetryButton) RetryButton.onClick.AddListener(SceneGame);
        if (ReturnMenuButton) ReturnMenuButton.onClick.AddListener(ReturnMenu);
        if (QuitButton) QuitButton.onClick.AddListener(() =>
        {
            Application.Quit();
        });
        if (StartGameButton) StartGameButton.onClick.AddListener(SceneGame);

        ScoreText.text = $"You lasted {FindObjectOfType<Score>().ScoreValue} secondes";
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