using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Player))]
public class PlayerInput : MonoBehaviour {

	Player player;
    private bool isLocked;
    private Transform draw;
    DataHolder database;
    private Vector2 velocity;
    private bool thinking;
    private Animator animator;
    private float isThinking = .5f;

    void Start () {
        GameObject.Find("PLayer").SetActive(true);
        thinking = false;
        isLocked = true;
        draw = GetComponent<Transform>();
		player = GetComponent<Player> ();
        animator = GetComponent<Animator>();
        database = GameObject.Find("SaveState").GetComponent<DataHolder>();
        database.Save();
        velocity = player.SaveVelocity();
    }

	void Update () {
        if (!thinking)
        {
            animator.SetBool("jumping", Input.GetKeyDown(KeyCode.UpArrow));
            animator.SetBool("running", Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1);
            Debug.Log("set");
        }
        else
        {
            if (isThinking > 0)
            {
                animator.SetBool("thinking", true);
                isThinking -= Time.deltaTime;
                Debug.Log("thinking");
            }
            else
            {
                thinking = false;
                isThinking = .5f;
            }
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            isLocked = !isLocked;
        }
        if (isLocked)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                thinking = true;
                velocity = player.SaveVelocity();
                database.Save();
            }
            else if (Input.GetKeyDown(KeyCode.C))
            {
                thinking = true;

                player.SetVelocity(velocity);
                database.Load();
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
