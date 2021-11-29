using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Push : MonoBehaviour
{
    [SerializeField] private float pushForceMagnitude;


    //handle pushing
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //Q for pushing
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("pulling");
            Rigidbody rigidbody = hit.collider.attachedRigidbody;
            if (rigidbody != null)
            {
                Vector3 pushForceDirection = hit.gameObject.transform.position - transform.position;
                pushForceDirection.y = 0;
                pushForceDirection.Normalize();
                rigidbody.AddForce(transform.forward * pushForceMagnitude * -1);
            }
        }


    }
}
