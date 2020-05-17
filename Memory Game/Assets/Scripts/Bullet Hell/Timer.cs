using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public Animator transition;
    public Text timeRemainingText;
    float timeLeft;
    void Start()
    {
        timeLeft = 20 + (20 * forgotten.forgottenList.Count);
        timeRemainingText.text = timeLeft.ToString() + " sec";
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timeRemainingText.text = timeLeft.ToString() + " sec";
        if (timeLeft < 0) {
        LevelLoader.LoadLevel(transition);
        }
    }
}
