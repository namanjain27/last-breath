using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    bool alive = true;

    public Rigidbody rb;
    float horizontal_input;
    public float run_speed = 10f;
    public float sideways_speed = 5f;

    public GameObject gameOverImage;

    void Start()
    {
        Time.timeScale = 1;
    }

    private void FixedUpdate()
    {
        if(!alive)
        {
            return;
        }

        Vector3 forward_move = transform.forward * run_speed * Time.fixedDeltaTime;
        Vector3 horizontal_move = transform.right * horizontal_input * sideways_speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forward_move + horizontal_move);
    }

    private void Update()
    {
        horizontal_input = Input.GetAxisRaw("Horizontal");

        if(transform.position.y < -5)
        {
            run_speed = 0;
            sideways_speed = 0;
            
            Invoke("Die", 0.6f);
            
        }
    }

    public void Die()
    {
        alive = false;
        // GameOver image active
        gameOverImage.SetActive(true);
        Time.timeScale = 0;

        //die audio
    }
}
