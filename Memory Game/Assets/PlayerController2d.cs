using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2d : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private Rigidbody2D rb;
    private float moveInput;
    private bool facingRight = true;
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public int extraJumpsVal;
    private int extraJumps;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        extraJumps = extraJumpsVal;
        rb = GetComponent<Rigidbody2D>();
    }
void Update(){
    if (isGrounded == true){
        extraJumps = extraJumpsVal;
    }

    if(Input.GetKeyDown(KeyCode.W) && extraJumps == 0 && isGrounded == true){
    rb.velocity = Vector2.up * jumpForce;
    Debug.Log("jumpin off da floor");
    }
    else if(Input.GetKeyDown(KeyCode.W) && extraJumps > 0){
        rb.velocity = Vector2.up * jumpForce;
        extraJumps--;
    }


}
    void FixedUpdate(){
    animator.SetFloat("Speed",Mathf.Abs(moveInput));
    isGrounded = Physics2D.OverlapCircle(groundCheck.position,checkRadius,whatIsGround);
    moveInput = Input.GetAxis("Horizontal");
    rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    if(facingRight == false && moveInput > 0){
        Flip();
    }
    else if (facingRight == true && moveInput <0){
        Flip();
    }
    }
    void Flip(){
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
