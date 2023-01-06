using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickMovement : MonoBehaviour
{
    public PlayerController playerControllerScript;
    public bool isSaved = false; 

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isSaved == true)
        {
            transform.position = playerControllerScript.transform.position;
        } 
    }

    private void onCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            isSaved = true;
        }
    }
}
