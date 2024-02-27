using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballManager : MonoBehaviour
{
    private static Rigidbody2D rb;
    private Vector3 lastVelocity;
    public static float ballStartSpeed = 0.0f;
    private Vector3 randomVelocity;
    private int randSpeedCount = 5;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    private void Start()
    {
 
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        lastVelocity = rb.velocity;
    }

 

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (randSpeedCount > 0)
        {
            randomVelocity = new Vector3(UnityEngine.Random.Range(-0.5f, 0.5f), UnityEngine.Random.Range (-0.5f, 0.5f), 0f);
            randSpeedCount--;
        }

        var speed = lastVelocity.magnitude + randomVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, coll.contacts[0].normal);

        rb.velocity = direction * Mathf.Max(speed, 0f);


        if (coll.gameObject.CompareTag("leftGoal"))
        {
            goalManager.rightPlayerScore++;
            restartBall();
            StartCoroutine(countdownManager.CountDown(3));

        }

        if (coll.gameObject.CompareTag("rightGoal"))
        {
            goalManager.leftPlayerScore++;
            restartBall();
            StartCoroutine(countdownManager.CountDown(3));
        }
    }
    public static void startGame()
    {
        ballStartSpeed = 10.0f;

        // Generate a random direction
        Vector2 randomDirection = UnityEngine.Random.insideUnitCircle.normalized;

        // Apply movement in the random direction
        rb.velocity = randomDirection * ballStartSpeed;
    }

    private void restartBall()
    {
        rb.velocity = new Vector3(0, 0, 0);
        rb.MovePosition(new Vector3(0, 0, 0));
    }
}

