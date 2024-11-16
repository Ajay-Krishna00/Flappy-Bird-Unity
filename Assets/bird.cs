using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private int jumpforce = 12;
    private Rigidbody2D rb;
    public LogicManager logic;
    private bool birdIsAlive = true;
    public AudioSource neonSFX;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //rb.velocity = new Vector3(3,0,0);

        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        neonSFX.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive== true)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpforce, 0); //or rb.velocity = Vector2.up * 10;

        }
        if(transform.position.y>13.5 || transform.position.y < -13.5)
        {
            logic.gameover();
            birdIsAlive = false;
            logic.highscore();
            neonSFX.Stop();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdIsAlive = false;
        logic.gameover();
        logic.highscore();
        neonSFX.Stop();
    }
}
