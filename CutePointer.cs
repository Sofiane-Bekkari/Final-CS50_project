using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutePointer : MonoBehaviour
{
    //public Rigidbody2D[] links;
    //public Ropes ropesScript;

    public PlayerX playerScript;
    [SerializeField]
    private int pointValue;

    private void Start()
    {
        // GET PLAYER SCRIPT
        playerScript = GameObject.Find("ELE").GetComponent<PlayerX>();
    }
    private void Update()
    {
        //ropesScript.cutOneOfLink = false; // PASS IT FALSE ON TEST
        // CUTE ROPE
        if (Input.GetMouseButton(1))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero); // HIT RAYCAST TO THE CHECK

            // CHECK IF HITING SOMETHING
            if (hit.collider != null)
            {

                if (hit.collider.tag == "Link") // IF TAG MATCH
                {
                    // ENABLE TRAIL
                    //opesScript.cutOneOfLink = true; // PASS IT TRUE
                    Destroy(hit.collider.gameObject);
                }
                if (hit.collider.tag == "Fruits")
                {
                    playerScript.UpdateScore(pointValue);
                    Destroy(hit.collider.gameObject);
                    Debug.Log("FRUIT HIT");

                }
            }
        }

    }
}
