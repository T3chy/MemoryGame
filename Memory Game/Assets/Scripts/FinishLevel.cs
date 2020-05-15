using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLevel : MonoBehaviour
{
    public Animator transition;
    // Start is called before the first frame update
private void OnTriggerEnter2D(Collider2D other){
    int nextlevel = SceneManager.GetActiveScene().buildIndex + 1;
    Debug.Log("exit time");
    if (nextlevel <= SceneManager.sceneCountInBuildSettings){
    LevelLoader.LoadLevel(SceneManager.GetActiveScene().buildIndex + 1,transition);
}
}
}
