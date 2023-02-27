using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeMovement : MonoBehaviour
{

    public Rigidbody2D rigidBody;       // Drag and drop RigidBody 2D
    public float swimSpeed = 6000f;
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
        
        Quaternion rot = transform.localRotation;
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.localRotation = Quaternion.Euler(0, 0.0f, rot.z);
            horizontalMove = 1.0f;
            facingRight = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.localRotation = Quaternion.Euler(0, 180.0f, rot.z);
            horizontalMove = -1.0f;
            facingRight = false;
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.localRotation = Quaternion.Euler(0, rot.y, 90.0f);
            verticalMove = -1.0f;
            upsideDown = false;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.localRotation = Quaternion.Euler(0, rot.y, 270.0f);
            verticalMove = 1.0f;
            upsideDown = true;
        }
    }
}