using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Player))]
public class PlayerInput : MonoBehaviour {

	Player player;
    private bool isLocked;
    private Transform draw;
    DataHolder database;
    private Vector2 velocity;

    void Start () {
        isLocked = true;
        draw = GetComponent<Transform>();
		player = GetComponent<Player> ();
        database = GameObject.Find("SaveState").GetComponent<DataHolder>();
    }

	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            isLocked = !isLocked;
        }
        if (isLocked)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                velocity = player.SaveVelocity();
                database.Save();
            }
            else if (Input.GetKeyDown(KeyCode.C) && velocity == null)
            {
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
