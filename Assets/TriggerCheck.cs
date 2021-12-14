using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TriggerCheck : MonoBehaviour
{
    public bool cross;
    public bool circle;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Cross")
        {
            cross = true;
        }

        if (other.tag == "Circle")
        {
            circle = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Cross")
        {
            cross = false;
        }

        if (other.tag == "Circle")
        {
            circle = false;
        }
    }

}
