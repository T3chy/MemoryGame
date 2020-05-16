using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
public class LevelLoader : MonoBehaviour
{

    public static int transitionTime = 1;


    
    public static void LoadLevel(int levelIndex,Animator transition){
        transition.SetTrigger("Start");
        Thread.Sleep(transitionTime*1000);
        SceneManager.LoadScene(levelIndex);

    }
}
