using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float time = 0;
    public TextMeshProUGUI text;
    private float roundtime;
    
    public float TimeCount => roundtime;
    
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        roundtime = Mathf.RoundToInt(time * 10f) / 10f;
        text.text = ($"  {roundtime}  s");
        time += Time.deltaTime;
    }
}
