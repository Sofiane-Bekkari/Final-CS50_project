using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopesGenerater : MonoBehaviour
{
    public Rigidbody2D hook; // MAIN HOOK *
    public GameObject linksPrefabs; // MAIN LINK *
    public GameObject[] fruitPrefabs; // ADD ON TEST // YET ON TEST
    public GameObject link; // ADD ON TEST
    public float distenceFromFruitEnd = 0.6f; // DISTENCE END *
    public float distenceFromFruittUp = 1f; // DISTENCE UP FRONT *
    public float distenceFromFruitLeftRight = 0.1f; // DISTENCE LEFT / RIGHT *
    public int links = 7;
    public bool cutOneOfLink = false; // TRY TO GET IT WHEN CUT LINK *TEST*

    // Start is called before the first frame update
    void Start()
    {

        // GENERATE ROPE
        GenerateRope();
    }
    // UPDATE


    // COROUTINE FUNCTION GENERAT FRUIT AT THE END
    IEnumerator instantaitFruit(Rigidbody2D prRb)
    {
        // wait amount of second
        int index = Random.Range(0, fruitPrefabs.Length); 
        yield return new WaitForSeconds(0.9f);

        // ALL ADDESITIONAL SCRIPT FOR NEEDS FEATURES
        GameObject fruit = Instantiate(fruitPrefabs[index], transform); // ADD ON TEST
        HingeJoint2D jointFruit = fruit.GetComponent<HingeJoint2D>();
        TrailRenderer trialFruit = fruit.GetComponent<TrailRenderer>(); // GET TRAIL COMPONENT
        Rigidbody2D fruitRb = fruit.GetComponent<Rigidbody2D>();

        // TEST ADD WEIGHT
        fruitRb.mass = 5; // try to add mass
        jointFruit.connectedBody = prRb;
        //prRb.constraints = RigidbodyConstraints2D.FreezeRotation; // NEW LINE ON TEST FREZZE PERB-
        jointFruit.anchor = new Vector2(-distenceFromFruitLeftRight, distenceFromFruittUp); // ADJESTMENT ANCHOR
        jointFruit.connectedAnchor = new Vector2(0f, -distenceFromFruitEnd);
        fruit.transform.localScale = new Vector2(1f, 1f); // SCALE IT

    }


    // GENERATE ROPE
    void GenerateRope()
    {
        Rigidbody2D previouseRb = hook; // FIRST RIGIDBODY
        //GameObject link; // FIRST RIGIDBODY
        for (int i = 1; i < links; i++)
        {
            GameObject link = Instantiate(linksPrefabs, transform); // GENERATE PREFABS
            HingeJoint2D joint = link.GetComponent<HingeJoint2D>(); // GET HINGE JOINT
            joint.connectedBody = previouseRb; // CONNECT BODIES

            // CHECK IF NOT THE LAST ITEM
            if (i < links - 1)
            {
                previouseRb = link.GetComponent<Rigidbody2D>(); // GET RIGIDBODY FOR THAT ITEM
                previouseRb.constraints = RigidbodyConstraints2D.FreezeRotation;
                Debug.Log("GOT NORMAL!");
            }
           
            else
            {
                StartCoroutine(instantaitFruit(previouseRb)); // THIS IS INSANE 
                //weight.ConnectRope(link.GetComponent<Rigidbody2D>()); // CONNECT LAST LINK TO THE WEIGHT
                Debug.Log("CONNECT THE FRUIT HERE!" + link);
            }
        }
    }

    private void Update() // UPDATE ON TEST
    {
       

    }

}
