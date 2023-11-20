using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    private float timeBetweenObstacles = 2f;
    private float startDelay = 1.5f;

    private Vector3 spawnPos = new Vector3(20, 0 ,0);

    [SerializeField] private GameObject obstacle;

    private void Start()
    {
        InvokeRepeating("instanciaObstaculo", startDelay, timeBetweenObstacles);
    }

    private void instanciaObstaculo()
    {
        Instantiate(obstacle, spawnPos, Quaternion.identity);
    }



}
