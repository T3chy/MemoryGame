using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class hitDetection : MonoBehaviour
{

    public Transform enemy;
    public Transform player;
    int startHealth;
    public Text healthtext;
    public float variable;
    public int variable2;
    void Start(){

        startHealth = variable2;
        healthtext.text = startHealth.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other){
        Destroy(other);
        startHealth -= 1;
        healthtext.text = startHealth.ToString();
        if (startHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    void FixedUpdate()
    {
        float dist = Vector3.Distance(enemy.position, transform.position);
        if (dist < variable)
        {
            startHealth-=1;
        }
    }

}
