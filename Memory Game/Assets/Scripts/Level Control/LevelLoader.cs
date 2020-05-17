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
        
        SceneManager.LoadScene("Bullet_Hell");

    }
    public static void backToPlatform(Animator transition)
    {
        transition.SetTrigger("Start");
        Thread.Sleep(transitionTime*1000);
        SceneManager.LoadScene(level + 1);
    }

}
