using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudSpawner : MonoBehaviour
{
    [SerializeField] private GameObject cloud;
    private float spawnrate = 5;
    private float spawntime = 0;
    private float highest1, highest2;
    private float lowest1, lowest2;
    private float heightoffset = 7;
    private float widthoffset = 7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnrate > spawntime)
        {
            spawntime += Time.deltaTime;
        }
        else
        {
            spawn();
            spawntime = 0;
        }
    }
    private void spawn()
    {
        highest1 = transform.position.y + heightoffset;
        lowest1 = transform.position.y - heightoffset;
        highest2 = transform.position.x + widthoffset;
        lowest2 = transform.position.x - widthoffset;
        Instantiate(cloud, new Vector3(Random.Range(lowest2, highest2), Random.Range(lowest1, highest1)), transform.rotation);
    }
}
