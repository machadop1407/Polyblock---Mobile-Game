using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class IAPBuyStars : MonoBehaviour
{
    public GameObject am;
    SoundEffects se;
    Purchaser p;


    public enum ItemType
    {
        Gold100,
        Gold500,
        Gold1000,
        NoAds
    }
    public ItemType itemType;
    // Start is called before the first frame update
    void Start()
    {
        p = GetComponent<Purchaser>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


   public void Buy()
    {
        switch(itemType)
        {
            case ItemType.Gold100:
           //     p.Buy100();
                break;

            case ItemType.Gold500:
                PlayerPrefs.SetInt("Star", PlayerPrefs.GetInt("Star") + 500);
                break;

            case ItemType.Gold1000:
                PlayerPrefs.SetInt("Star", PlayerPrefs.GetInt("Star") + 1000);
                break;

            case ItemType.NoAds:
                IAPManager.RemoveAds();
                break;

        }
    }
}
