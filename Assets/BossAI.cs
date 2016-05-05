﻿using UnityEngine;
using System.Collections;


public class BossAI : MonoBehaviour {

    public Transform target;
    public Rigidbody2D rb;
    private float timer;
    float speed;
	// Use this for initialization
	void Awake () 
    {
        speed = 3;
        timer = 5;
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        
        Vector2 direction = new Vector2(target.position.x - transform.position.x, target.position.y - transform.position.y);
        Debug.Log(direction);
        //Vector2 distance = new Vector2(Mathf.Abs(target.position.x))
        //Vector2 distance = Vector2.Distance(target.position., transform.TransformVector);
        //direction.Normalize();
        Debug.Log(direction.sqrMagnitude);
        if (direction.sqrMagnitude < 70)
        {
            timer -= Time.deltaTime;
            direction.Normalize();
            rb.velocity -= direction * Time.deltaTime * speed;
            if (timer <= 0)
            {
                rb.velocity = new Vector2(Random.Range(0, 4), Random.Range(0, 4));
                timer = 3;
                
            }
        }
        else
        {
            direction.Normalize();
            rb.velocity += direction * Time.deltaTime;
        }
        
        //if (timer <= 0)
        //{
        //    rb.velocity = new Vector2(Random.Range(0, 4), Random.Range(0, 4));
        //    timer = 3;
        //}
	}
}
