using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 100;

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

        Vector3 moveDirection = new Vector3(1, 0, 0);

        transform.position += moveDirection * speed * Time.deltaTime;
        
    }
}
