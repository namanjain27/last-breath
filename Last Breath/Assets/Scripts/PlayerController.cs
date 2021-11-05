using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.SceneManagement;
=======
>>>>>>> 0470485868f7ec581c37f80dc8ce20cf4daba289

public class PlayerController : MonoBehaviour
{

<<<<<<< HEAD
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
=======
    public float speed = 5;
    public Rigidbody rb;

    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove);
    }

    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    //void Update()
    //{
        
    //}
>>>>>>> 0470485868f7ec581c37f80dc8ce20cf4daba289
}
