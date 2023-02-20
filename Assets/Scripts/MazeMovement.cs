using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeMovement : MonoBehaviour
{

    public Rigidbody2D rigidBody;       // Drag and drop RigidBody 2D
    public float swimSpeed = 250f;
    private float horizontalMove = 0f;
    private float verticalMove = 0f;
    public bool facingRight;
    public bool upsideDown;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        facingRight = true;
        upsideDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * swimSpeed;
        verticalMove = Input.GetAxisRaw("Vertical") * swimSpeed;
    }

    private void FixedUpdate() {
        rigidBody.velocity = new Vector2(horizontalMove * Time.fixedDeltaTime, verticalMove * Time.fixedDeltaTime);
        
        // if moving right
        if(horizontalMove > 0 && !facingRight) {
            ChangeDirection();
            horizontalMove = 1.0f;
            facingRight = true;
        }
        // if moving left
        else if (horizontalMove < 0 && facingRight) {
            ChangeDirection();
            horizontalMove = -1.0f;
            facingRight = false;
        } 
        // if moving upward
        if(verticalMove > 0 && upsideDown) {
            ChangeDirection();
            verticalMove = -1.0f;
            upsideDown = false;
        }
        // if moving downward
        else if (verticalMove < 0 && !upsideDown) {
            ChangeDirection();
            verticalMove = 1.0f;
            upsideDown = true;
        }
    }

    private void ChangeDirection () {
        Quaternion rot = transform.localRotation;
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.localRotation = Quaternion.Euler(rot.x, 0.0f, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.localRotation = Quaternion.Euler(rot.x, 180.0f, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.localRotation = Quaternion.Euler(rot.x, rot.y, 90.0f);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.localRotation = Quaternion.Euler(rot.x, rot.y, 270.0f);
        }
     }
}

