using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class IAPManager : MonoBehaviour
{

    public static GameObject newRemoveAdsBttn;
    public static GameObject oldRemoveAdsBttn;
    public static GameObject removeAdsPriceUI;
    public static GameObject newRemoveAdsBttn1;
    public static GameObject oldRemoveAdsBttn1;
    public static GameObject removeAdsPriceUI1;
    public static GameObject am;
    SoundEffects se;

    private void Start()
    {
        PlayerPrefs.GetInt("RemovedAds",0);

        if (PlayerPrefs.GetInt("RemovedAds") == 1)
        {
            newRemoveAdsBttn.SetActive(true);
            oldRemoveAdsBttn.SetActive(false);
            removeAdsPriceUI.SetActive(false);
            newRemoveAdsBttn1.SetActive(true);
            oldRemoveAdsBttn1.SetActive(false);
            removeAdsPriceUI1.SetActive(false);
        }
    }


    public static void RemoveAds()
    {
        Debug.Log("Purchased");
        PlayerPrefs.SetInt("RemovedAds", 1);
        newRemoveAdsBttn.SetActive(true);
        oldRemoveAdsBttn.SetActive(false);
        removeAdsPriceUI.SetActive(false);
        newRemoveAdsBttn1.SetActive(true);
        oldRemoveAdsBttn1.SetActive(false);
        removeAdsPriceUI1.SetActive(false);
    }


}
