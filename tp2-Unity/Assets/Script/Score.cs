using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private TextMeshProUGUI text;

    public void IncrementScore()
    {
        score++;
        text.text = score.ToString();
    }
}