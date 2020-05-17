using UnityEngine;
using System.Collections;
using System.Threading;
using System.Collections.Generic;  
public class clickToForget : MonoBehaviour {
    public List<string> forgottens = new List<string>();
    public Animator animator;
    public GameObject color;
    void OnMouseDown()
    {
                animator.SetBool("Deleting",true);
                Thread.Sleep(500);
                color.SetActive(false);
                forgottens.Add(color.name + "_bullet");
                Debug.Log(color.name + "_bullet");
                    Thread.Sleep(500);
                
        animator.SetBool("Deleting",false);     
    }
}