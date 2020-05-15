using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Range(0, 1)]
    public float smoother;
    public Transform player;
    private Transform cam;
    private float displacement;
    private bool isLocked;
    public bool IsLocked 
    {
        get { return isLocked; } 
        set { isLocked = value; } 
    }

    private void Start()
    {
        cam = GetComponent<Transform>();
    }



    void FixedUpdate()
    {
        if (isLocked)
        {
            displacement = player.position.x - cam.position.x;
            cam.position = new Vector3(cam.position.x + (displacement * smoother), player.position.y, cam.position.z);
        }
        
    }
}
