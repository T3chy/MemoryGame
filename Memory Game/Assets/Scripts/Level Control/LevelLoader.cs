using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
public class LevelLoader : MonoBehaviour
{
    public static int level = 0;
    public static int transitionTime = 1;
    public static void LoadLevel(Animator transition){
        transition.SetTrigger("Start");
        Thread.Sleep(transitionTime*1000);
        if (level > 3) { 
        SceneManager.LoadScene("Bullet_Hell");
        }else {
            backToPlatform(transition);
        }
    }
    public static void backToPlatform(Animator transition)
    {
        level = level + 1;
        if ((level >= SceneManager.GetActiveScene().buildIndex) && (SceneManager.GetActiveScene().name == "bullet_hell")) {
                    Application.Quit();
        }else{
        transition.SetTrigger("Start");
        Thread.Sleep(transitionTime*1000);
        forgotten.forgottenList = new List<string>();
        SceneManager.LoadScene(level);
    }}

}
