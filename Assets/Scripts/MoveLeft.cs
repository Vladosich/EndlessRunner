using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    PlayerController playerControllerScript;
    float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (Input.GetKey(KeyCode.S))
            {
                
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
        }
        if(transform.position.x < -10 && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        
    }
}
