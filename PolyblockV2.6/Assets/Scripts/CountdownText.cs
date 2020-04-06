using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownText : MonoBehaviour
{
    private Text starText;
    // Start is called before the first frame update
    void Start()
    {
        starText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        starText.text = PlayerPrefs.GetInt("Star").ToString() + "x";

    }
}
