using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InRange : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Holdable>())
        {
            other.GetComponent<Holdable>().inRange = true;
            this.GetComponentInParent<HoldObject>().canHold = true;
            this.GetComponentInParent<HoldObject>().holdableObject = other.gameObject;

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Holdable>())
        {
            other.GetComponent<Holdable>().inRange = false;
            this.GetComponentInParent<HoldObject>().canHold = false;
            this.GetComponentInParent<HoldObject>().holdableObject = null;
        }
    }


}
