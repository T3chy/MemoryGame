using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
     float horizontalMV = 0f;
    bool jump = false;
    public float runSpeed = 40f;
    // Update is called once per frame
    void Update()
    {
        //get input
        horizontalMV = Input.GetAxisRaw("Horizontal")* runSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            UnityEngine.Debug.Log("jumped");
            jump = true;
        }
    }
    void FixedUpdate ()
    {
        // move da boi
        controller.Move(horizontalMV*Time.fixedDeltaTime,false,jump);
        jump = false;
    }
}
