using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 startPos;
    private float restPos;
    // Start is called before the first frame update
    void Start()
    {
        // GETTING START POSITION
        startPos = transform.position;
        // this is very helpful formula for repeat BACKGROUND
        restPos = GetComponent<BoxCollider2D>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        
        // CHECK SIZE BACKGROUND
        if (transform.position.x < startPos.x - restPos)
        {
            transform.position = startPos;
            
        }
    }
}
