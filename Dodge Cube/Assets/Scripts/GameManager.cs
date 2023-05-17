using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI scoreText;
    float currentScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentScore = (float)System.Math.Round(Time.time * 2.3, 1);
        scoreText.SetText(currentScore.ToString());
    }
}
