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
        Vector3 moveDirection = transform.position;
        if (Input.GetKey("w"))
        {
            moveDirection.x += speed * Time.deltaTime;
            transform.eulerAngles = new Vector3(transform.rotation.x, 0, transform.rotation.z);
 

        }
        if (Input.GetKey("s"))
        {
            moveDirection.x -= speed * Time.deltaTime;
            transform.eulerAngles = new Vector3(transform.rotation.x, 180, transform.rotation.z);
        }
        if (Input.GetKey("a"))
        {
            moveDirection.z += speed * Time.deltaTime;
            transform.eulerAngles = new Vector3(transform.rotation.x, 270, transform.rotation.z);
        }
        if (Input.GetKey("d"))
        {
            moveDirection.z -= speed * Time.deltaTime;
            transform.eulerAngles = new Vector3(transform.rotation.x, 90, transform.rotation.z);
        }


        transform.position = moveDirection;// * speed * Time.deltaTime;

    }
    //void Update()
    //{

    //    Vector3 moveDirection = new Vector3(1, 0, 0);

    //    transform.position += moveDirection * speed * Time.deltaTime;

    //}
}
