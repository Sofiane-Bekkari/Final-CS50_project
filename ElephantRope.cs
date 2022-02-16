using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElephantRope : MonoBehaviour
{
    private Rigidbody2D rbElephantRope;
    [SerializeField] float moveSpeed;
    public float horizontalInput;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        rbElephantRope = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Mouse X");
        verticalInput = Input.GetAxis("Mouse Y");

        // MOVE WITH VELOCITY
        if (horizontalInput >= 0.1 && Input.GetKey(KeyCode.Mouse1))
        {
            rbElephantRope.velocity = new Vector2(horizontalInput * moveSpeed, rbElephantRope.velocity.y);
            Debug.Log("FRONT ROPE");
        }
        if (horizontalInput <= -0.1 && Input.GetKey(KeyCode.Mouse1))

        {
            rbElephantRope.velocity = new Vector2(horizontalInput * moveSpeed, rbElephantRope.velocity.y);
            Debug.Log("BACK ROPE");
        }

    }
}
