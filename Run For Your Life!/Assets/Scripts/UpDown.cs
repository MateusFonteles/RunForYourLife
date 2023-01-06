using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    
    public float distanceToCover = 0.1f; 
    public float speed = 4;
    public Vector3 startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = startingPosition;
        movement.y += distanceToCover * Mathf.Sin(Time.time * speed);
        transform.position = movement; 
    }
}
