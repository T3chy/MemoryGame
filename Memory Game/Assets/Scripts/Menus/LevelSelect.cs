using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;
public class LevelSelect : MonoBehaviour
{
   //public Animator transition;
        public static int transitionTime = 1;
    public Button level1;
    public Button level2;
    public Button level3;
    public Button level4;
    public Button level5;
    public Button BackButton;
    private void Start()
    {
        level1.onClick.AddListener(delegate{goToLevel(1);});
        level2.onClick.AddListener(delegate{goToLevel(2);});
        level3.onClick.AddListener(delegate{goToLevel(3);});
        level4.onClick.AddListener(delegate{goToLevel(4);});
        level5.onClick.AddListener(delegate{goToLevel(5);});
        BackButton.onClick.AddListener(delegate{goToLevel(0);});
    }

    void goToLevel(int levelNum){
 //                   transition.SetTrigger("Start");
        Thread.Sleep(transitionTime*1000);
        SceneManager.LoadScene(levelNum);
    }
}