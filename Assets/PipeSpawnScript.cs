using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    [SerializeField]private GameObject pipe;
    [SerializeField] private float spawnrate = 5;
    private float spawntime = 0;
    private float heightOffSet= 9;
    // Start is called before the first frame update
    void Start()
    {
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawntime < spawnrate)
        {
            spawntime += Time.deltaTime;
        }  
        else
        {
            spawn();
            spawntime = 0;
        }
    }
    void spawn()
    {
        float highest = transform.position.y + heightOffSet;
        float lowest = transform.position.y - heightOffSet;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowest,highest)), transform.rotation);
    }
}
