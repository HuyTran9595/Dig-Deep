using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldingRope : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Rigidbody robeRB;
    [SerializeField] GameObject robe0;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (other.gameObject.GetComponent<Player_Pull>().IsPulling())
            {
                robeRB.isKinematic = false;
                Destroy(robe0);
            }
        }
    }
}
