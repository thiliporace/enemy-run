using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyRun : MonoBehaviour
{
    [SerializeField] private Rigidbody enemy;
    [SerializeField] private Transform player;
    [SerializeField] private float distance = 0f;
    [SerializeField] private float force = 2f;


    private void Awake()
    {
        enemy = GetComponent<Rigidbody>();
    }

    void Start()
    {
        player = FindObjectOfType<PlayerMovement>().transform;
    }

  
    void Update()
    {
        RunFromPlayer();
    }

    void RunFromPlayer()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < distance)
        {
            enemy.AddForce(new Vector3(0,0,force));
            //Debug.Log(force);
        }

    }
}
