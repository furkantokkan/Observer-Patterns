using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text text;
    private int score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = score.ToString();
    }
    public void AddScore(object obj)
    {
        int amount = (int)obj;
        score += amount;
    }
}
