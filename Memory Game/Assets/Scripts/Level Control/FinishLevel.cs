using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLevel : MonoBehaviour
{
    public Animator transition;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("exit time");
        int nextlevel = SceneManager.GetActiveScene().buildIndex + 1;

        if (nextlevel <= SceneManager.sceneCountInBuildSettings)
        {
            LevelLoader.level = SceneManager.GetActiveScene().buildIndex;
            LevelLoader.LoadLevel(transition);
        }
    }
}
