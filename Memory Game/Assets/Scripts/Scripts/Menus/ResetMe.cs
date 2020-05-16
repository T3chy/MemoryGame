using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetMe : MonoBehaviour
{
    public Button resetButton;
    public GameObject[] colors;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = resetButton.GetComponent<Button>();
        btn.onClick.AddListener(resetEm);
    }
    void resetEm(){

        foreach(GameObject color in colors){
            color.SetActive(true);
        }

    }
}
