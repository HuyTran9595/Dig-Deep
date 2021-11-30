using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holdable : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject holder;
    public float holdingHeight;
    public bool inRange;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (holder)
        {
            this.transform.position = new Vector3( holder.transform.GetChild(1).position.x,holdingHeight, holder.transform.GetChild(1).position.z);
        }
        else
        {

        }
    }
}
