using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorePayer : MonoBehaviour
{

    public Sprite[] playerSprites;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Players") == 0)
        {
            GetComponent<Image>().sprite = playerSprites[0];
        }
        else if (PlayerPrefs.GetInt("Players") == 1)
        {
            GetComponent<Image>().sprite = playerSprites[1];
        }
        else if (PlayerPrefs.GetInt("Players") == 2)
        {
            GetComponent<Image>().sprite = playerSprites[2];
        }
        else if (PlayerPrefs.GetInt("Players") == 3)
        {
            GetComponent<Image>().sprite = playerSprites[3];
        }
        else if (PlayerPrefs.GetInt("Players") == 4)
        {
            GetComponent<Image>().sprite = playerSprites[4];
        }
        else if (PlayerPrefs.GetInt("Players") == 5)
        {
            GetComponent<Image>().sprite = playerSprites[5];
        }
        else if (PlayerPrefs.GetInt("Players") == 6)
        {
            GetComponent<Image>().sprite = playerSprites[6];
        }
        else if (PlayerPrefs.GetInt("Players") == 7)
        {
            GetComponent<Image>().sprite = playerSprites[7];
        }
        else if (PlayerPrefs.GetInt("Players") == 8)
        {
            GetComponent<Image>().sprite = playerSprites[8];
        }
        else if (PlayerPrefs.GetInt("Players") == 9)
        {
            GetComponent<Image>().sprite = playerSprites[9];
        }
        else if (PlayerPrefs.GetInt("Players") == 10)
        {
            GetComponent<Image>().sprite = playerSprites[10];
        }
        else if (PlayerPrefs.GetInt("Players") == 11)
        {
            GetComponent<Image>().sprite = playerSprites[11];
        }
        else if (PlayerPrefs.GetInt("Players") == 12)
        {
            GetComponent<Image>().sprite = playerSprites[12];
        }
    }
}
