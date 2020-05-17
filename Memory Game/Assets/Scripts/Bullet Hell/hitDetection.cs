using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class hitDetection : MonoBehaviour
{
    int startHealth;
    public Text healthtext;
    void Start(){
    startHealth = 5 - forgotten.forgottenList.Count;
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
}
