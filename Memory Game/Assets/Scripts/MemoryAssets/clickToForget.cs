using UnityEngine;
using System.Collections;
using System.Threading;

public class clickToForget : MonoBehaviour {

    //public GameObject quad;
    public GameObject color;
    private Color alpha;
    private bool fade;
    private void Start()
    {
        fade = false;
        //quad = GameObject.Find("Quad");
        //quad.SetActive(false);
        // quad = GameObject.Find("Quad").GetComponent<Renderer>().material.color;
    }

    void OnMouseDown()
    {
        //fade = true;
        //quad.SetActive(true);
        Thread.Sleep(500);
        color.SetActive(false);
        forgotten.forgottenList.Add(color.name + "_bullet");
        print(forgotten.forgottenList.Count);
        //alpha = quad.GetComponent<Renderer>().material.color;
    }       
        
    /*void Update()
    {
        if (alpha.a > 0)
        {
            alpha.a--;
            quad.GetComponent<Renderer>().material.color = alpha;
        } else if (alpha.a == 0)
        {
            quad.SetActive(false);
            alpha.a = 255;
            quad.GetComponent<Renderer>().material.color = alpha;
        }
    }*/
}
