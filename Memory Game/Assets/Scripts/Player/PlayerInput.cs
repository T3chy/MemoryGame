using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Player))]
public class PlayerInput : MonoBehaviour
{

    Player player;
    private bool isLocked;
    private Transform draw;
    DataHolder database;
    private Vector2 velocity;
    private Animator animator;
    private float thinkTime;

    void Start()
    {

        thinkTime = 0f;
        isLocked = true;
        draw = GetComponent<Transform>();
        player = GetComponent<Player>();
        animator = GetComponent<Animator>();
        database = GameObject.Find("SaveState").GetComponent<DataHolder>();

        velocity = player.SaveVelocity();
        database.Save();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            isLocked = !isLocked;
        }
        if (isLocked)
        {


            if (thinkTime <= 0f)
            {
                animator.SetBool("jumping", Input.GetAxisRaw("Vertical") == 1);
                animator.SetBool("running", Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1);
                animator.SetBool("thinking", false);
            }
            else
            {
                thinkTime -= Time.deltaTime;
            }


            if (Input.GetKeyDown(KeyCode.X))
            {
                velocity = player.SaveVelocity();
                database.Save();
                animator.SetBool("thinking", true);
                thinkTime = .5f;
            }
            else if (Input.GetKeyDown(KeyCode.C))
            {
                player.SetVelocity(velocity);
                database.Load();
                animator.SetBool("thinking", true);
                thinkTime = .5f;


            }
            Vector2 directionalInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            if (Input.GetAxisRaw("Horizontal") != 0)
            {
                draw.localScale = new Vector3(Mathf.Abs(draw.localScale.x) * Input.GetAxisRaw("Horizontal"), draw.localScale.y, draw.localScale.z);
            }
            player.SetDirectionalInput(directionalInput);

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                player.OnJumpInputDown();
            }
            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                player.OnJumpInputUp();
            }
        }
    }
}
