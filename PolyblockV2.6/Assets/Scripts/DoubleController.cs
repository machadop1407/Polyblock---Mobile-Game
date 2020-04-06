using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoubleController : MonoBehaviour
{
    public GameObject psPlayer;
    float currCountdownValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

 private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            PlayerMovement.doubleScored = true;
            PlayerMovement.justDoubled = true;
            GameObject ps = Instantiate(psPlayer, GameObject.Find("Player").transform.position, Quaternion.identity);
            Destroy(ps, 2f);
            Destroy(gameObject);
        }

    }

}
