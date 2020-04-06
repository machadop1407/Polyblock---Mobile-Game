using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    private Text highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        highScoreText = GetComponent<Text>();
        highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMovement.score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", PlayerMovement.score);
            highScoreText.text = PlayerMovement.score.ToString();
        }
    }
}
