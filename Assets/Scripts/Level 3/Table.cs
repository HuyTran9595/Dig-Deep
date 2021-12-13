using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))] 
public class Table : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] GameObject box1Collider;
    [SerializeField] GameObject box2Collider;
    bool box1Collide = true;
    bool box2Collide = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; 
    }


    private void Update()
    {
        if(!box1Collide && !box2Collide)
        {
            rb.isKinematic = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetInstanceID() == box1Collider.GetInstanceID())
        {
            box1Collide = true;
            rb.isKinematic = true;
        }

        if (collision.gameObject.GetInstanceID() == box2Collider.GetInstanceID())
        {
            box2Collide = true;
            rb.isKinematic = true;
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.GetInstanceID() == box1Collider.GetInstanceID())
        {
            box1Collide = false;
            //Debug.Log("1 leave");
        }

        if (collision.gameObject.GetInstanceID() == box2Collider.GetInstanceID())
        {
            box2Collide = false;
            //Debug.Log("2 leave");
        }
    }



}
