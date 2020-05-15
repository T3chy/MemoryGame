using UnityEngine;
using System.Collections;
using System.Threading;

public class clickToForget : MonoBehaviour {


    public Animator animator;
    public GameObject color;


    void OnMouseDown()
    {
                animator.SetBool("Deleting",true);
                Thread.Sleep(500);
                color.SetActive(false);
                        Thread.Sleep(500);
                
        animator.SetBool("Deleting",false);     
    }
}