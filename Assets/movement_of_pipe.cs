using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_of_pipe : MonoBehaviour

{
    private float movement = 12;
    [SerializeField]private float acceleration=2f;
    public float DeadZone = -50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement += acceleration * Time.deltaTime;
        transform.position = transform.position + (Vector3.left * movement) * Time.deltaTime;
        if (transform.position.x < DeadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject  );
        }
    }
}
