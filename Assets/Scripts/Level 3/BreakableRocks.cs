using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableRocks : MonoBehaviour
{
    [SerializeField] GameObject[] breakableRocks;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ExplosivePotion")
        { 
            foreach(GameObject breakableRock in breakableRocks)
            {
                Destroy(breakableRock);
            }
            Destroy(other.gameObject);
        }

    }

}
