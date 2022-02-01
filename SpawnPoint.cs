using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    // DRAW ON GiZMOS
    private void OnDrawGizmos()
    {
        RaycastHit2D hit2D;

        if (Physics2D.Raycast(transform.position, -Vector2.up))
        {
            Debug.DrawLine(transform.position, Vector2.up, Color.blue); // DRAWING LINE
        }
    }
}
