using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class StoreButton : MonoBehaviour{
    void OnMouseOver()
    {
        //Ifyour mouse hovers over the GameObject with the script attaced, outputthis message
        Debug.Log("Mouse is over GameObject.");
    }

    void OnMouseExit()
    {
      //The mouse is no longr hovering over the GameObject so output this messge each frme
        Debug.Log("Moue is no longer on GameObject.");
    }
}