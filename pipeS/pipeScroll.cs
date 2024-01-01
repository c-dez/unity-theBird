using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UIElements;

public class pipeScroll : MonoBehaviour
{
    // Start is called before the first frame update
    public float scrollSpeed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + 
        (Vector3.left * scrollSpeed) * Time.deltaTime;
    }
}
