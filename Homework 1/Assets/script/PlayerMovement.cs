using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 30;

    [SerializeField]
    private BoxCollider boxColider;

    private void Start()
    {
        boxColider = GetComponent<BoxCollider>();
        GetComponentInChildren<BoxCollider>();
        GetComponentInParent<BoxCollider>();
        FindObjectOfType<BoxCollider>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -2, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 2, 0);
        }
    }
}
