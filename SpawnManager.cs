using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabRopes; // ROPE PREFABS
    public GameObject[] prefabFruits; // FRUITS PREFABS
    private float startDelay = 2;
    private float repeatDelay = 2;
    [SerializeField]
    private float yPos = 15f;
    [SerializeField]
    private float xPos = 35f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnInstantiate", startDelay, repeatDelay);
        //InvokeRepeating("SpawnFruits", 3, 20);
    }

    void SpawnInstantiate()
    {
        // generate random index form prefabs []
        int indexObs = Random.Range(0, prefabRopes.Length);  
        float spawnY = Random.Range(yPos,+yPos); // RANGE OF Y
        Vector2 randomPos = new Vector2(xPos, spawnY); // NEW VECTOR RANDOM POS Y/X 

        // Instantiation 
        Instantiate(prefabRopes[indexObs], randomPos, prefabRopes[indexObs].transform.rotation);
    }
}
