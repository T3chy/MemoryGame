using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHolder : MonoBehaviour
{
    public Transform grid;
    public Transform player;
    public Rigidbody2D playerRB;
    public GameObject black;
    public GameObject purple;
    public GameObject red;
    public GameObject yellow;
    public GameObject green;

    private Vector3 gridPos;
    private Vector3 playerPos;
    private Vector2 playerVel;
    private bool blackOn;
    private bool purpleOn;
    private bool redOn;
    private bool yellowOn;
    private bool greenOn;
    

    public void Save() {
        gridPos = grid.position;
        playerPos = player.position;
        playerVel = playerRB.velocity;
        blackOn = black.activeSelf;
        purpleOn = purple.activeSelf;
        redOn = red.activeSelf;
        yellowOn = yellow.activeSelf;
        greenOn = green.activeSelf;
    }

    public void Load() {
        grid.position = gridPos;
        player.position = playerPos;
        playerRB.velocity = playerVel;
        black.SetActive(blackOn);
        purple.SetActive(purpleOn);
        red.SetActive(redOn);
        yellow.SetActive(yellowOn);
        green.SetActive(greenOn);
    }
}
