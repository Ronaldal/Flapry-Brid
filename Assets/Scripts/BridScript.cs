using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridScript : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float plapStrength;
    public LogicScript logic;
    public bool bridIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && bridIsAlive)
        {
            rigidbody2D.velocity = Vector2.up * plapStrength;
        }
        if(transform.position.y>21 || transform.position.y < -21)
        {
            logic.gameOverFunc();
            bridIsAlive = false;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOverFunc();
        bridIsAlive = false;
    }
}
