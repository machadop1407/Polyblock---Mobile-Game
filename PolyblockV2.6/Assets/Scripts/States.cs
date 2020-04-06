using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.Advertisements;

public class States : MonoBehaviour
{

    public GameObject uiText1;
    public GameObject uiText2;
    public GameObject uiText3;
    public GameObject uiText4;
    public GameObject uiText5;
    public GameObject uiText6;
    public GameObject uiText7;
    public GameObject uiText8;
    public GameObject backBttnStore;
    public GameObject startBTTNS;
    public GameObject moveBTTNS;
    public GameObject unMuted;
    public GameObject muted;
    public GameObject pauseBttn;
    public GameObject pausePanel;
    public GameObject mainGamePanel;
    public GameObject mainPanel;
    public GameObject storePanel;
    public GameObject aboutPanel;
    public GameObject am;
    SoundEffects se;

    public static bool isPlaying = false;
    public static bool isInUI = false;
    public static bool started = false;


    // Start is called before the first frame update
    void Start()
    {
        uiText2.GetComponent<Animator>().enabled = false;
        uiText3.GetComponent<Animator>().enabled = false;
        PlayerPrefs.GetInt("Audio", 0);
        se = am.GetComponent<SoundEffects>();

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Audio") == 0)
        {
            AudioListener.volume = 1;
            unMuted.SetActive(true);
            muted.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Audio") == 1)
        {
            AudioListener.volume = 0;
            unMuted.SetActive(false);
            muted.SetActive(true);
        }

    }


    public void StartGame()
    {
        if (!isPlaying && !isInUI)
         {  
                uiText1.SetActive(false);
                uiText7.SetActive(false);
                uiText8.SetActive(false);
                startBTTNS.SetActive(false);
                moveBTTNS.SetActive(true);
                pauseBttn.SetActive(true);  
                uiText2.GetComponent<Animator>().enabled = true;
                uiText3.GetComponent<Animator>().enabled = true;
                StartCoroutine(startGame());
                uiText4.SetActive(true);
                uiText5.SetActive(true);
                uiText6.SetActive(true);
                started = true;
            }
        }


    public void About()
    {
        mainPanel.SetActive(false);
        mainGamePanel.SetActive(false);
        aboutPanel.SetActive(true);
        isInUI = true;
        se.Button();
    }

    public void Store()
    {
        mainPanel.SetActive(false);
        mainGamePanel.SetActive(false);
        storePanel.SetActive(true);
        isInUI = true;
        se.Button();

    }

    public void Retry()
    {
        SceneManager.LoadScene("MainScene");
        isPlaying = false;
        PlayerMovement.score = 0;
        se.Button();
        PlayerMovement.doubleScored = false;

    }

    public void Pause()
    {
       // isPlaying = false;
        //Time.timeScale = 0;
        pausePanel.SetActive(true);
        moveBTTNS.SetActive(false);
        se.Button();

    }

    public void Resume()
    {
       // isPlaying = true;
        //Time.timeScale = 1;
        pausePanel.SetActive(false);
        moveBTTNS.SetActive(true);
        se.Button();

    }

    public void MainMenu()
    {
        isPlaying = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("MainScene");
        se.Button();

    }

    public void Mute()
    {
        PlayerPrefs.SetInt("Audio", 1);


    }

    public void unMute()
    {
        PlayerPrefs.SetInt("Audio", 0);

    }

    public void BackFromStore()
    {
        mainPanel.SetActive(true);
        mainGamePanel.SetActive(true);
        storePanel.SetActive(false);
        isInUI = false;
        se.Button();

    }

    public void BackFromAbout()
    {
        mainPanel.SetActive(true);
        mainGamePanel.SetActive(true);
        aboutPanel.SetActive(false);
        isInUI = false;
        se.Button();

    }

    IEnumerator startGame()
    {
        yield return new WaitForSeconds(0.5f);
        isPlaying = true;
       
    }

    public void ShowAdForStars()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo", new ShowOptions() { resultCallback = HandleRewardAdResult });
        }
        se.Button();

    }


    public void HandleRewardAdResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                PlayerPrefs.SetInt("Star", PlayerPrefs.GetInt("Star") + 10);
                break;
            case ShowResult.Failed:
                break;
        }
    }

  
}
