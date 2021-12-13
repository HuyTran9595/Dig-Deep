using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockage1BoxCheck : MonoBehaviour
{
    BoxCollider boxCollider;
    public bool isCollided = false;



    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 10 || //table
            other.gameObject.layer == 11) //box
        {
            isCollided = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 10 || //table
            other.gameObject.layer == 11) //box
        {
            isCollided = false;
        }
    }



}
