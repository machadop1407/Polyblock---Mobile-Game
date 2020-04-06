using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingEnemyController : MonoBehaviour
{
    public float speed = 150;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x - 2f, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        if (PlayerMovement.score > 10)
        {
            speed = 200;
        } else if (PlayerMovement.score > 30)
        {
            speed = 250;
        }

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
       

        if (coll.gameObject.tag == "DestroyEnemy")
        {
            Destroy(gameObject);
        }
    }
}
