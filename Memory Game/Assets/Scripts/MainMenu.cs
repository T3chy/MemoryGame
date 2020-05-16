using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
   // public Animator transition;
        public static int transitionTime = 1;
    public Button startButton;
    public Button levelSelectButton;
    public Button gameInfoButton;
    public Button quitButton;
    void Start()
    {
        startButton.onClick.AddListener(startGame);
        levelSelectButton.onClick.AddListener(restartGame);
        gameInfoButton.onClick.AddListener(gameInfo);
        quitButton.onClick.AddListener(quitGame);
    }

    // Update is called once per frame
    void quitGame (){
        Debug.Log("quit button time");
        Application.Quit();
    }
    void startGame(){
    //            transition.SetTrigger("Start");
        Thread.Sleep(transitionTime*1000);
        SceneManager.LoadScene(1);
    }
    void restartGame(){

    }
    void gameInfo(){

    }
}