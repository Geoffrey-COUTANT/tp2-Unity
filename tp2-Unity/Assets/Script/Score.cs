using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private TextMeshProUGUI text;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("money"))
        {
            IncrementScore();
        }
    }

    private void IncrementScore()
    {
        score++;
        text.text = score.ToString();
    }
}