using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class footsteps : MonoBehaviour
{
    public Animator anim;
    private float timeElapsed = 0f;
    public Rigidbody2D rb;
    AnimatorClipInfo[] m_CurrentClipInfo;
    void Update(){
        m_CurrentClipInfo = this.anim.GetCurrentAnimatorClipInfo(0);
        Debug.Log(m_CurrentClipInfo[0].clip);
        Debug.Log(rb.velocity.y);
        if (((m_CurrentClipInfo[0].clip.name == "Player_Run") && timeElapsed > .494) && rb.velocity.y == 0) {
            FindObjectOfType<AudioManager>().Play("footstep");
            timeElapsed = 0;
    }timeElapsed += Time.deltaTime;
    }  
}
