using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour

{
    private float topBound = 30;
    private float lowerBound = -10;
    private float sideBound = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if position of object is outside of set boundary
        if (transform.position.z > topBound)
        {
            // Delete objetct if out of bounds
            Destroy(gameObject);

        } else if (transform.position.z < lowerBound)
        {
            
            Debug.Log("Game Over");
            Destroy(gameObject);

        } else if (Mathf.Abs(transform.position.x) > sideBound)
        {
            Destroy(gameObject);
        }
    }
}