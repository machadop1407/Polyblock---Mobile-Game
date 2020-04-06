using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarController : MonoBehaviour
{

    public GameObject am;
    SoundEffects se;

    // Start is called before the first frame update
    void Start()
    {
        transform.parent = null;
        se = am.GetComponent<SoundEffects>();

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            se.Star();
            PlayerPrefs.SetInt("Star", PlayerPrefs.GetInt("Star") + 1);
        }

    }
}
