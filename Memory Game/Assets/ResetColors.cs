using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetColors : MonoBehaviour
{
    public Button resetButton;
    public GameObject red;
    public GameObject green;
    public GameObject purple;
    public GameObject yellow;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = resetButton.GetComponent<Button>();
        btn.onClick.AddListener(resetEm);
    }
    void resetEm(){


        red.SetActive(true);
        green.SetActive(true);
        purple.SetActive(true);
        yellow.SetActive(true);
  
    }
}
