using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudMovement : MonoBehaviour
{
    
    private int movement = 6;
    private float eliminate = -50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movement) * Time.deltaTime;
        if(transform.position.x < eliminate)
        {
            Destroy(gameObject);
        }
        
    }

    
}
