using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    [SerializeField] GameObject door;

    private void Start()
    {
        door.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "BluePotion")
        {
            door.SetActive(true);
            Destroy(this.gameObject);
        } 
    }

}
