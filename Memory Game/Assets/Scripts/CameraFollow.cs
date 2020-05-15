using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Range(0, 1)]
    public float smootherX;
    [Range(0, 1)]
    public float smootherY;
    public Transform player;
    public Transform cam;
    private float displacement;
    public bool isLocked;
    public float camSpeed;


    private void Start()
    {
        isLocked = true;
        camSpeed = .2f;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            isLocked = !isLocked;
            
        }
    }

    void FixedUpdate()
    {
        if (isLocked)
        {
            displacement = player.position.x - cam.position.x;
            cam.position = new Vector3(cam.position.x + (displacement * smootherX), player.position.y + (displacement * smootherY), cam.position.z);
        }
        else
        {
            cam.position= new Vector3(cam.position.x + Input.GetAxisRaw("Horizontal") * camSpeed, cam.position.y + Input.GetAxisRaw("Vertical") * camSpeed, cam.position.z);

        }

    }
}
