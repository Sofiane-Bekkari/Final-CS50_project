using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitBehavoirs : MonoBehaviour
{
    private PlayerX player;
    public GameObject playerScript;
    private Rigidbody2D rb;
    [SerializeField] float moveSpeed;
    public float score; 
    private int valuePoint = 1; 

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerX>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // MOVE FRUITS TO THE LEFT
        rb.AddForce(Vector2.left * moveSpeed * Time.deltaTime);
    }

    // ON COLLISION WITH PLAYER
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.UpdateScore(valuePoint); // 1 POINT ON EACH FRUIT 
            Destroy(gameObject);
            Debug.Log("PLAYER EAT ME!");
        }
        if (collision.gameObject.CompareTag("EndZone"))
        {
            Destroy(gameObject);
            Debug.Log("DESTROY ON END ZONE!");
        }
    }
}
