using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float moveSpeed;
    private bool moveRight;
    public Transform player;
    public Transform enemy;
    public float smoothing;
    void Start()
    {
        moveSpeed= 2f;
        moveRight= true;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy.position.x > player.position.x)
        {
            enemy.localScale = new Vector3(Mathf.Abs(enemy.localScale.x) , enemy.localScale.y, enemy.localScale.z);
        }
        else
        {
            enemy.localScale = new Vector3(Mathf.Abs(enemy.localScale.x)*-1f, enemy.localScale.y, enemy.localScale.z);
        }
        enemy.position = new Vector3(enemy.position.x+((player.position.x - enemy.position.x) * smoothing), enemy.position.y + ((player.position.y - enemy.position.y) * smoothing), 0);
        //(enemy.position.x-player.position.x)
    } 
}
