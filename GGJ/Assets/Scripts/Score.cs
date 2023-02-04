using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    float timer;
    float score;

    [SerializeField] TextMeshProUGUI playerScore;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer>1)
        {
            score++;
            timer = 0;
        }

        playerScore.text = score.ToString();
    }
}
