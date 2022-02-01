using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerX : MonoBehaviour
{
    private Rigidbody2D rb;
    public TextMeshProUGUI textScore;
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpSpeed;
    public float score;
    public float horizontalInput;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Mouse X");
        verticalInput = Input.GetAxis("Mouse Y");

        // MOVE WITH VELOCITY
        if (horizontalInput >= 0.1 && Input.GetKey(KeyCode.Mouse0))
        {
            rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
            Debug.Log("FRONT");
        }
        if (horizontalInput <= -0.1 && Input.GetKey(KeyCode.Mouse0))

        {
            rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
            Debug.Log("BACK");
        }

        // JUMP
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }

    }

    // UPDATE SCORE
    // UPDATE SCORE
    public void UpdateScore(int valuePoint)
    {
        //score = 0;
        score += valuePoint;

        textScore.text = "EATING: " + score;


        if (score == 5) // DO AWESOME THING
        {
            //textHighScore.gameObject.SetActive(true);
            //enemySound.PlayOneShot(higherScore);
            //textGameOver.gameObject.SetActive(true); // DISPALY GAME OVER
        }
        //else

        //textHighScore.gameObject.SetActive(false);

    }
}
