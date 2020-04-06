using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InclinedMovingCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 A = Quaternion.Euler(0, 0, -13.399f) * Vector3.left;
         transform.position -= A;

    }


    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Returner")
        {
            transform.position = new Vector3(3.2f, transform.position.y, transform.position.z);
        }

        if (coll.gameObject.tag == "DestroyEnemy")
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
