﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalZombieBehavior : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Rigidbody2D body;

    private int playerDistance = 10;
    private float speed = 1f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var direction = Vector3.Distance(transform.position, player.transform.position);

        if(direction < playerDistance)
        {
            body.velocity = (player.transform.position - transform.position).normalized * speed;
        }
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.gameObject.layer == LayerMask.NameToLayer("Player"))
    //    {

    //    }
    //}
}