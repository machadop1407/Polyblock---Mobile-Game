using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class PlayerMovement : MonoBehaviour
{
    Camera cam;
    Vector3 targetPlayer;
    Vector3 targetCam;
    Vector3 targetDestroyer;
    GameObject doubleObject;
    public GameObject deathAnim;
    public GameObject destroyer;
    public GameObject doubleScore;
    public GameObject deathPanel;
    public GameObject movingBttns;
    public GameObject adPanel;
    public GameObject am;
    SoundEffects se;
    public Color[] newColor;
    int color = 0;

    //SPRITES//
    public Sprite[] playerSprites;

    public static int score = 0;
    public float speed;
    public static bool died;
    private bool hasScored = false;
    public static bool scored = false;
    public static bool doubleScored = false;
    public static bool justDoubled = false;
    bool hasWatchedAd = false;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        se = am.GetComponent<SoundEffects>();
        targetPlayer = transform.position;
        targetCam = cam.transform.position;
        targetDestroyer = destroyer.transform.position;
        died = false;

        PlayerPrefs.GetInt("AmountPlayed", 0);
        PlayerPrefs.SetInt("AmountPlayed", PlayerPrefs.GetInt("AmountPlayed") + 1);

        Debug.Log(PlayerPrefs.GetInt("AmountPlayed"));

        Advertisement.Initialize("3242872", false);
    }

    // Update is called once per frame
    void Update()
    {

        if (States.started)
        {
            StartCoroutine(ShowBannerWhenReady());
        }
        if (justDoubled)
        {
            StartCoroutine(CountDown());
            justDoubled = false;
        }
        if (PlayerPrefs.GetInt("Players") == 0)
        {
            GetComponent<SpriteRenderer>().sprite = playerSprites[0];
            deathAnim.GetComponent<ParticleSystem>().textureSheetAnimation.SetSprite(0, playerSprites[0]);
        } else if (PlayerPrefs.GetInt("Players") == 1)
        {
            GetComponent<SpriteRenderer>().sprite = playerSprites[1];
            deathAnim.GetComponent<ParticleSystem>().textureSheetAnimation.SetSprite(0, playerSprites[1]);
        }
        else if (PlayerPrefs.GetInt("Players") == 2)
        {
            GetComponent<SpriteRenderer>().sprite = playerSprites[2];
            deathAnim.GetComponent<ParticleSystem>().textureSheetAnimation.SetSprite(0, playerSprites[2]);
        }
        else if (PlayerPrefs.GetInt("Players") == 3)
        {
            GetComponent<SpriteRenderer>().sprite = playerSprites[3];
            deathAnim.GetComponent<ParticleSystem>().textureSheetAnimation.SetSprite(0, playerSprites[3]);
        }
        else if (PlayerPrefs.GetInt("Players") == 4)
        {
            GetComponent<SpriteRenderer>().sprite = playerSprites[4];
            deathAnim.GetComponent<ParticleSystem>().textureSheetAnimation.SetSprite(0, playerSprites[4]);
        }
        else if (PlayerPrefs.GetInt("Players") == 5)
        {
            GetComponent<SpriteRenderer>().sprite = playerSprites[5];
            deathAnim.GetComponent<ParticleSystem>().textureSheetAnimation.SetSprite(0, playerSprites[5]);
        }
        else if (PlayerPrefs.GetInt("Players") == 6)
        {
            GetComponent<SpriteRenderer>().sprite = playerSprites[6];
            deathAnim.GetComponent<ParticleSystem>().textureSheetAnimation.SetSprite(0, playerSprites[6]);
        }
        else if (PlayerPrefs.GetInt("Players") == 7)
        {
            GetComponent<SpriteRenderer>().sprite = playerSprites[7];
            deathAnim.GetComponent<ParticleSystem>().textureSheetAnimation.SetSprite(0, playerSprites[7]);
        }
        else if (PlayerPrefs.GetInt("Players") == 8)
        {
            GetComponent<SpriteRenderer>().sprite = playerSprites[8];
            deathAnim.GetComponent<ParticleSystem>().textureSheetAnimation.SetSprite(0, playerSprites[8]);
        }
        else if (PlayerPrefs.GetInt("Players") == 9)
        {
            GetComponent<SpriteRenderer>().sprite = playerSprites[9];
            deathAnim.GetComponent<ParticleSystem>().textureSheetAnimation.SetSprite(0, playerSprites[9]);
        }
        else if (PlayerPrefs.GetInt("Players") == 10)
        {
            GetComponent<SpriteRenderer>().sprite = playerSprites[10];
            deathAnim.GetComponent<ParticleSystem>().textureSheetAnimation.SetSprite(0, playerSprites[10]);
        }
        else if (PlayerPrefs.GetInt("Players") == 11)
        {
            GetComponent<SpriteRenderer>().sprite = playerSprites[11];
            deathAnim.GetComponent<ParticleSystem>().textureSheetAnimation.SetSprite(0, playerSprites[11]);
        }
        else if (PlayerPrefs.GetInt("Players") == 12)
        {
            GetComponent<SpriteRenderer>().sprite = playerSprites[12];
            deathAnim.GetComponent<ParticleSystem>().textureSheetAnimation.SetSprite(0, playerSprites[12]);
        }

        this.GetComponent<Rigidbody2D>().position = Vector3.Lerp(this.transform.position, targetPlayer, speed);
        cam.transform.position = Vector3.Lerp(cam.transform.position, targetCam, speed);
        destroyer.transform.position = Vector3.Lerp(destroyer.transform.position, targetDestroyer, speed);
    }


   public void Move()
    {
        if (States.isPlaying && !States.isInUI)
        {

                Vector3 tempTarget = targetPlayer;
                tempTarget.y += 5;
                targetPlayer = tempTarget;
                se.Jump();
                StartCoroutine(MoveCam());

            float doubleScorePercent = Random.Range(0, 100);
            if (score % 10 == 0 && score != 0)
            {
                if (doubleScorePercent < 50)
                {
                    Debug.Log(doubleScorePercent);
                    Vector3 doublePos = new Vector3(0f, transform.position.y + 8, 179.1952f);
                    doubleObject = Instantiate(doubleScore, doublePos, Quaternion.identity);
                }
            }
        }
    }

    IEnumerator MoveCam()
    {
        yield return new WaitForSeconds(0.8f);
        Vector3 tempTarget1 = targetCam;
        tempTarget1.y += 5;
        targetCam = tempTarget1;
        Vector3 tempTarget2 = targetDestroyer;
        tempTarget2.y += 5;
        targetDestroyer = tempTarget2;
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            Instantiate(deathAnim, transform.position, Quaternion.identity);
            Time.timeScale = 0.8f;
            scored = false;
            se.Death();
            movingBttns.SetActive(false);
            States.started = false;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            if (!hasWatchedAd)
            {
                StartCoroutine(PanelDeath());
                hasWatchedAd = true;
            }
            else
            {
                DeathPanel();
                hasWatchedAd = false;
            }
            if (PlayerPrefs.GetInt("RemovedAds") == 0)
            {
                if (PlayerPrefs.GetInt("AmountPlayed") % 3 == 0)
                {
                    if (Advertisement.IsReady())
                    {
                        Advertisement.Show("video");
                    }
                }
            }

            
        }


        if (coll.gameObject.tag == "Scored")
        {
            if (!doubleScored)
            {
                score = score + 1;
            }

            if (doubleScored)
            {
                score = score + 2;

            }

            scored = true;
            if (score %  5 == 0 && score != 0)
            {
                color = color + 1;
                if (color > 4)
                {
                    color = 0;
                }
                cam.backgroundColor = newColor[color];
            }
        }

        if (coll.gameObject.tag == "ScoredCircle")
        {

            if (!doubleScored)
            {
                score = score + 1;
            }

            if (doubleScored)
            {
                score = score + 2;

            }
            scored = true;
            if (score % 5 == 0 && score != 0)
            {
                color = color + 1;
                if (color > 4)
                {
                    color = 0;
                }
                cam.backgroundColor = newColor[color];
            }
        }

        if (coll.gameObject.tag == "doubleScore")
        {
            se.Pick2x();
        }
   }



    public void ShowRewardeAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo", new ShowOptions() { resultCallback = HandleContinueAdResult });
        }
        se.Button();

    }


    public void HandleContinueAdResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                StartCoroutine(continuePlaying());
                break;
            case ShowResult.Failed:
                //  Debug.Log("FAILED TO LOAD ? Internet?");
                break;
        }
    }

    IEnumerator continuePlaying()
    {
        adPanel.SetActive(false);
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        transform.position = new Vector3(-188.0262f, destroyer.transform.position.y + 5, 179.1952f);
        movingBttns.SetActive(true);
        GetComponent<BoxCollider2D>().enabled = false;
        yield return new WaitForSeconds(1.5f);
        GetComponent<BoxCollider2D>().enabled = true;

    }

    IEnumerator PanelDeath()
    {
        yield return new WaitForSeconds(0.5f);
        adPanel.SetActive(true);

    }

    public void DeathPanel()
    {
        deathPanel.SetActive(true);
        adPanel.SetActive(false);
        se.Button();

    }

    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(5f);
        doubleScored = false;
    }

    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady("bannerAds"))
        {
            yield return new WaitForSeconds(0.5f);
        }
        Advertisement.Banner.Show("bannerAds");
        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
    }
}
