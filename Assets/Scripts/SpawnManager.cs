using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstacles;
    Vector3 spawnPosition = new Vector3(30, 0, 0);
    float startDelay = 2f;
    float repeatRate = 2f;
    PlayerController playerControllerScript;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacles", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacles()
    {
        if (playerControllerScript.gameOver == false)
        {
            int obstacleIndex = Random.Range(0, obstacles.Length);
            Instantiate(obstacles[obstacleIndex], spawnPosition, obstacles[obstacleIndex].transform.rotation);
        }
    }
}
