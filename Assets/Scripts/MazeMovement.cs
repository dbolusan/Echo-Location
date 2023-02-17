using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeMovement : MonoBehaviour
{

    public Rigidbody2D rigidBody;       // Drag and drop RigidBody 2D
    public float swimSpeed = 40f;
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
        
        // if moving right and facing left
        if(horizontalMove > 0 && !facingRight) {
            FlipHorizontal();
        }
        // if moving left and facing right
        else if (horizontalMove < 0 && facingRight) {
            FlipHorizontal();
        } 
        // if moving upward and upside down
        if(verticalMove > 0 && upsideDown) {
            FlipVertical();
        }
        // if moving downward and right side up
        else if (verticalMove < 0 && !upsideDown) {
            FlipVertical();
        }
    }

    private void FlipHorizontal() {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x  *= -1;
        transform.localScale = scale;
    }

    private void FlipVertical() {
        upsideDown = !upsideDown;
        Vector3 scale = transform.localScale;
        scale.y  *= -1;
        transform.localScale = scale;
    }
}
