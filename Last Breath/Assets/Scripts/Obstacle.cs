using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour
{
    

    PlayerController playerMovement;
    // Start is called before the first frame update
    void Start()
    {

        playerMovement = GameObject.FindObjectOfType<PlayerController>();
        
    }

    void OnCollisionEnter (Collision collision)
    {
        if(collision.gameObject.name == "player")
        {
            playerMovement.run_speed = 0;
            playerMovement.sideways_speed= 0;

            playerMovement.Die();
        }
    }

   


    // Update is called once per frame
    void Update()
    {
        
    }
}
