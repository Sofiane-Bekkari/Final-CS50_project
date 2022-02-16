using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerRope : MonoBehaviour
{
   
    [SerializeField] float moveSpeed;
    [SerializeField] Camera mainCamra; // GET CAMERA 
    public PlayerX playerScript; // GET SCORE SCRIPT
    public float horizontalInput;
    public float verticalInput;
    public int valuePoint = 1;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.Find("ELE").GetComponent<PlayerX>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Mouse X");
        verticalInput = Input.GetAxis("Mouse Y");
        //Debug.Log(mainCamra.ScreenToWorldPoint(Input.mousePosition));

        Vector3 mouseWorldPosition = mainCamra.ScreenToWorldPoint(Input.mousePosition); // SET VAR FOR MOUSE POSITION
        mouseWorldPosition.z = 0f; // RESET TO 0 FOR Z AXIS

        // MOVE WITH VELOCITY
        if (Input.GetKey(KeyCode.Mouse1)) // IF CLICK MOUSE 
        {
            transform.position = mouseWorldPosition; // THAN START MOVE MOUSE POSITION 
            Debug.Log("MOUSE POSITION WORKS");

        } 

    }

    // TRIGGER SCORE
    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (collision.gameObject.CompareTag("Fruits") && gameObject.CompareTag("Nose"))
        {
            playerScript.UpdateScore(valuePoint);
            Destroy(collision.gameObject);
            Debug.Log("TRIGGER WITH FRUIT" + collision.gameObject);
        }*/
    }
}
