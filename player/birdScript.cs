using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D rigidBody;
    public int flapStr;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.velocity = Vector2.up * flapStr;

        }
        
    }
}
