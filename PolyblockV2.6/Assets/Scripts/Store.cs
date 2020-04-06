using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{

    public GameObject locked1;
    public GameObject locked2;
    public GameObject locked3;
    public GameObject locked4;
    public GameObject locked5;
    public GameObject locked6;
    public GameObject locked7;
    public GameObject locked8;
    public GameObject locked9;
    public GameObject locked10;
    public GameObject locked11;

    public GameObject unlocked1;
    public GameObject unlocked2;
    public GameObject unlocked3;
    public GameObject unlocked4;
    public GameObject unlocked5;
    public GameObject unlocked6;
    public GameObject unlocked7;
    public GameObject unlocked8;
    public GameObject unlocked9;
    public GameObject unlocked10;
    public GameObject unlocked11;

    public GameObject buyStarPanel;
    public GameObject am;
    SoundEffects se;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetInt("Player", 0);

        se = am.GetComponent<SoundEffects>();

        if (PlayerPrefs.GetInt("Cube2") == 1)
        {
            locked1.SetActive(false);
            unlocked1.SetActive(true);
        } 
         if (PlayerPrefs.GetInt("Cube3") == 1)
        {
            locked2.SetActive(false);
            unlocked2.SetActive(true);
        }
         if (PlayerPrefs.GetInt("Cube4") == 1)
        {
            locked3.SetActive(false);
            unlocked3.SetActive(true);
        }
         if (PlayerPrefs.GetInt("Cube5") == 1)
        {
            locked4.SetActive(false);
            unlocked4.SetActive(true);
        }
         if (PlayerPrefs.GetInt("Cube6") == 1)
        {
            locked5.SetActive(false);
            unlocked5.SetActive(true);
        }
         if (PlayerPrefs.GetInt("Cube7") == 1)
        {
            locked6.SetActive(false);
            unlocked6.SetActive(true);
        }
         if (PlayerPrefs.GetInt("Cube8") == 1)
        {
            locked7.SetActive(false);
            unlocked7.SetActive(true);
        }
         if (PlayerPrefs.GetInt("Cube9") == 1)
        {
            locked8.SetActive(false);
            unlocked8.SetActive(true);
        }
         if (PlayerPrefs.GetInt("Cube10") == 1)
        {
            locked9.SetActive(false);
            unlocked9.SetActive(true);
        }
         if (PlayerPrefs.GetInt("Cube11") == 1)
        {
            locked10.SetActive(false);
            unlocked10.SetActive(true);
        }
         if (PlayerPrefs.GetInt("Cube12") == 1)
        {
            locked11.SetActive(false);
            unlocked11.SetActive(true);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Cube1()
    {
        PlayerPrefs.SetInt("Players", 0);
        se.Button();


    }

    public void Cube2()
    {

        if (PlayerPrefs.GetInt("Star") > 49 && PlayerPrefs.GetInt("Cube2") == 0)
        {
            PlayerPrefs.SetInt("Cube2", 1);
            PlayerPrefs.SetInt("Star", PlayerPrefs.GetInt("Star") - 50);
            locked1.SetActive(false);
            unlocked1.SetActive(true);
        }
        else if(PlayerPrefs.GetInt("Star") < 49 && PlayerPrefs.GetInt("Cube2") == 0)
        {
            buyStarPanel.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Cube2") == 1)
        {
            PlayerPrefs.SetInt("Players", 1);
        }

        se.Button();

    }


    public void Cube3()
    {
        if (PlayerPrefs.GetInt("Star") > 49 && PlayerPrefs.GetInt("Cube3") == 0)
        {
            PlayerPrefs.SetInt("Cube3", 1);
            PlayerPrefs.SetInt("Star", PlayerPrefs.GetInt("Star") - 50);
            locked2.SetActive(false);
            unlocked2.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Star") < 49 && PlayerPrefs.GetInt("Cube3") == 0)
        {
            buyStarPanel.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Cube3") == 1)
        {
            PlayerPrefs.SetInt("Players", 2);
        }
        se.Button();

    }

    public void Cube4()
    {
        if (PlayerPrefs.GetInt("Star") > 99 && PlayerPrefs.GetInt("Cube4") == 0)
        {
            PlayerPrefs.SetInt("Cube4", 1);
            PlayerPrefs.SetInt("Star", PlayerPrefs.GetInt("Star") - 100);
            locked3.SetActive(false);
            unlocked3.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Star") < 99 && PlayerPrefs.GetInt("Cube4") == 0)
        {
            buyStarPanel.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Cube4") == 1)
        {
            PlayerPrefs.SetInt("Players", 3);
        }
        se.Button();

    }

    public void Cube5()
    {
        if (PlayerPrefs.GetInt("Star") > 99 && PlayerPrefs.GetInt("Cube5") == 0)
        {
            PlayerPrefs.SetInt("Cube5", 1);
            PlayerPrefs.SetInt("Star", PlayerPrefs.GetInt("Star") - 100);
            locked4.SetActive(false);
            unlocked4.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Star") < 99 && PlayerPrefs.GetInt("Cube5") == 0)
        {
            buyStarPanel.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Cube5") == 1)
        {
            PlayerPrefs.SetInt("Players", 4);
        }
        se.Button();

    }

    public void Cube6()
    {
        if (PlayerPrefs.GetInt("Star") > 99 && PlayerPrefs.GetInt("Cube6") == 0)
        {
            PlayerPrefs.SetInt("Cube6", 1);
            PlayerPrefs.SetInt("Star", PlayerPrefs.GetInt("Star") - 100);
            locked5.SetActive(false);
            unlocked5.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Star") < 99 && PlayerPrefs.GetInt("Cube6") == 0)
        {
            buyStarPanel.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Cube6") == 1)
        {
            PlayerPrefs.SetInt("Players", 5);
        }
        se.Button();

    }

    public void Cube7()
    {
        if (PlayerPrefs.GetInt("Star") > 199 && PlayerPrefs.GetInt("Cube7") == 0)
        {
            PlayerPrefs.SetInt("Cube7", 1);
            PlayerPrefs.SetInt("Star", PlayerPrefs.GetInt("Star") - 200);
            locked6.SetActive(false);
            unlocked6.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Star") < 199 && PlayerPrefs.GetInt("Cube7") == 0)
        {
            buyStarPanel.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Cube7") == 1)
        {
            PlayerPrefs.SetInt("Players", 6);
        }
        se.Button();

    }

    public void Cube8()
    {
        if (PlayerPrefs.GetInt("Star") > 199 && PlayerPrefs.GetInt("Cube8") == 0)
        {
            PlayerPrefs.SetInt("Cube8", 1);
            PlayerPrefs.SetInt("Star", PlayerPrefs.GetInt("Star") - 200);
            locked7.SetActive(false);
            unlocked7.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Star") < 199 && PlayerPrefs.GetInt("Cube8") == 0)
        {
            buyStarPanel.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Cube8") == 1)
        {
            PlayerPrefs.SetInt("Players", 7);
        }
        se.Button();

    }

    public void Cube9()
    {
        if (PlayerPrefs.GetInt("Star") > 199 && PlayerPrefs.GetInt("Cube9") == 0)
        {
            PlayerPrefs.SetInt("Cube9", 1);
            PlayerPrefs.SetInt("Star", PlayerPrefs.GetInt("Star") - 200);
            locked8.SetActive(false);
            unlocked8.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Star") < 199 && PlayerPrefs.GetInt("Cube9") == 0)
        { 

        buyStarPanel.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Cube9") == 1)
        {
            PlayerPrefs.SetInt("Players", 8);
        }
        se.Button();

    }

    public void Cube10()
    {
        if (PlayerPrefs.GetInt("Star") > 299 && PlayerPrefs.GetInt("Cube10") == 0)
        {
            PlayerPrefs.SetInt("Cube10", 1);
            PlayerPrefs.SetInt("Star", PlayerPrefs.GetInt("Star") - 300);
            locked9.SetActive(false);
            unlocked9.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Star") < 299 && PlayerPrefs.GetInt("Cube10") == 0)

        {
            buyStarPanel.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Cube10") == 1)
        {
            PlayerPrefs.SetInt("Players", 9);
        }
        se.Button();

    }

    public void Cube11()
    {
        if (PlayerPrefs.GetInt("Star") > 299 && PlayerPrefs.GetInt("Cube11") == 0)
        {
            PlayerPrefs.SetInt("Cube11", 1);
            PlayerPrefs.SetInt("Star", PlayerPrefs.GetInt("Star") - 300);
            locked10.SetActive(false);
            unlocked10.SetActive(true);
        }
        else if(PlayerPrefs.GetInt("Star") < 299 && PlayerPrefs.GetInt("Cube11") == 0)

        {
            buyStarPanel.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Cube11") == 1)
        {
            PlayerPrefs.SetInt("Players", 10);
        }
        se.Button();

    }

    public void Cube12()
    {
        if (PlayerPrefs.GetInt("Star") > 299 && PlayerPrefs.GetInt("Cube12") == 0)
        {
            PlayerPrefs.SetInt("Cube12", 1);
            PlayerPrefs.SetInt("Star", PlayerPrefs.GetInt("Star") - 300);
            locked11.SetActive(false);
            unlocked11.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Star") < 299 && PlayerPrefs.GetInt("Cube12") == 0)

        {
            buyStarPanel.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Cube12") == 1)
        {
            PlayerPrefs.SetInt("Players", 11);
        }
        se.Button();

    }

    public void BackFromBuyStar()
    {
        buyStarPanel.SetActive(false);
        se.Button();
    }

}
