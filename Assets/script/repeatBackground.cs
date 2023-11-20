using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatBackground : MonoBehaviour
{
    private float repeatANcho;

    private Vector3 startPos;



    private void Start()
    {

        startPos = transform.position;

        repeatANcho = GetComponent<BoxCollider>().size.x / 2;

    }

    private void Update()
    {
        if (transform.position.x < startPos.x - repeatANcho)
        {
            transform.position = startPos;
        }
    }

}
