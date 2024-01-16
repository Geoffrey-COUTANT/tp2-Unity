using System;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int ScoreValue { get; private set; } = 0;
    [SerializeField] private TextMeshProUGUI text;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void IncrementScore()
    {
        ScoreValue++;
        text.text = ScoreValue.ToString();
    }
}