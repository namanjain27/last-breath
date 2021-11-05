using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour
{
    Vector3 offset;
    public GameObject player;
    private void Start()
    {
        offset = transform.position - player.transform.position;
    }
    private void Update()
    {
        Vector3 cam_pos = player.transform.position + offset;
        cam_pos.x = 0;
        transform.position = cam_pos; 
    }
}
