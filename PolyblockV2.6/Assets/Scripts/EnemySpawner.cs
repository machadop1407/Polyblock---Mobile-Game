using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    Vector3 targetEnemy;
    public GameObject[] enemies;
    GameObject lastEnemy;
    States st;

    double probabilityOfCircle = 40;
    double probabilityOfRotatingCube = 20;
    double probabilityOfRotatingOctagonal = 50;
    bool movingCube;
    bool circleEnemy;
    bool circleLast = false;


    // Start is called before the first frame update
    void Start()
    {
        targetEnemy = new Vector3(1.98f, enemies[0].transform.position.y, -1.610783f);
        lastEnemy = enemies[0];
    }

    // Update is called once per frame
    void Update()
    {

        if (lastEnemy.tag == "MovingCube")
        {
            circleLast = false;
        }
        else if (lastEnemy.tag == "Enemy")
        {
            circleLast = true;

        }
    }


    public void Spawn()
    {
        if (States.isPlaying && !States.isInUI)
        {

            if (!PlayerMovement.died)
            {
           

                float enemyPercentage = Random.Range(0, 100);
                if (enemyPercentage > probabilityOfCircle)
                {

                    float rotatingMovingPercentage = Random.Range(0, 100);
                    Vector3 tempTarget = targetEnemy;
                    if (lastEnemy.tag == "MovingCube")
                    {
                        tempTarget.y += 5;
                    }
                    else if (lastEnemy.tag == "Enemy")
                    {
                        tempTarget.y += 3;

                    }

                    targetEnemy = tempTarget;

                    GameObject newEnemy;
                    if (rotatingMovingPercentage < probabilityOfRotatingCube)
                    {
                        newEnemy = Instantiate(enemies[2], targetEnemy, Quaternion.identity);

                    }
                    else
                    {
                        newEnemy = Instantiate(enemies[0], targetEnemy, Quaternion.identity);
                    }

                    lastEnemy = newEnemy;
                    circleLast = false;



                }
                else if (enemyPercentage < probabilityOfCircle)
                {

                    Vector3 tempTarget1 = targetEnemy;
                    float rotatingPercentage = Random.Range(0, 100);
                    if (lastEnemy.tag == "MovingCube")
                    {
                        tempTarget1.y += 12;
                    }
                    else if (lastEnemy.tag == "Enemy")
                    {
                        tempTarget1.y += 5;

                    }

                    targetEnemy = tempTarget1;
                    GameObject newEnemy;
                    if (!circleLast)
                    {
                        if (rotatingPercentage < probabilityOfRotatingOctagonal)
                        {
                            newEnemy = Instantiate(enemies[3], targetEnemy, Quaternion.identity);

                        }
                        else
                        {
                            newEnemy = Instantiate(enemies[1], targetEnemy, Quaternion.identity);
                        }
                        lastEnemy = newEnemy;
                        circleLast = true;
                    }
                    else
                    {
                        float rotatingMovingPercentage = Random.Range(0, 100);
                        Vector3 tempTarget = targetEnemy;
                        if (lastEnemy.tag == "MovingCube")
                        {
                            tempTarget.y += 5;
                        }
                        else if (lastEnemy.tag == "Enemy")
                        {
                            tempTarget.y += 3;

                        }

                        targetEnemy = tempTarget;

                        GameObject newEnemy1;
                        if (rotatingMovingPercentage < probabilityOfRotatingCube)
                        {
                            newEnemy1 = Instantiate(enemies[2], targetEnemy, Quaternion.identity);

                        }
                        else
                        {
                            newEnemy1 = Instantiate(enemies[0], targetEnemy, Quaternion.identity);
                        }

                        lastEnemy = newEnemy1;
                        circleLast = false;
                    }

                }
            }
        }
    }

}



