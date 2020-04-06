using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public GameObject[] audios;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jump()
    {
        GameObject newAudio = Instantiate(audios[0]);
        Destroy(newAudio, 2f);
    }

    public void Death()
    {
        GameObject newAudio = Instantiate(audios[1]);
        Destroy(newAudio, 2f);
    }

    public void Star()
    {
        GameObject newAudio = Instantiate(audios[2]);
        Destroy(newAudio, 2f);
    }

    public void Button()
    {
        GameObject newAudio = Instantiate(audios[3]);
        Destroy(newAudio, 2f);
    }

    public void Pick2x()
    {
        GameObject newAudio = Instantiate(audios[4]);
        Destroy(newAudio, 2f);
    }
}
