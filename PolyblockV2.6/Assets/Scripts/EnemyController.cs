using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (PlayerMovement.score > 5)
        {
            speed = 3;
        } else if (PlayerMovement.score > 20)
        {
            speed = 8;
        }
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
