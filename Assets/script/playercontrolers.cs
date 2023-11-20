using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrolers : MonoBehaviour
{
    private Rigidbody playerRigidbody;

    private bool isOnTheGrownd;

    private float forceMagnitute = 10f;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        isOnTheGrownd = true;
    }

    private void Start()
    {
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnTheGrownd)
        {
            playerRigidbody.AddForce(Vector3.up * forceMagnitute, ForceMode.Impulse);
            isOnTheGrownd =false;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            isOnTheGrownd = true;
        }
        
    }



}
