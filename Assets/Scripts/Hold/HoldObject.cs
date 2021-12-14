using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldObject : MonoBehaviour
{
    public bool canHold;
    public bool isHolding;
    public GameObject holdableObject;
    public float throwForce;
    public GameObject rangeCheck;

    // Start is called before the first frame update
    void Start()
    {
        rangeCheck = this.transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (isHolding)
        {
            rangeCheck.gameObject.SetActive(false);
        }
        else
        {
            rangeCheck.gameObject.SetActive(true);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (!isHolding && canHold)
            {
                holdableObject.transform.parent = this.transform;
                holdableObject.GetComponent<Holdable>().holder = this.transform.gameObject;
                isHolding = true;
            }else if (isHolding)
            {
                holdableObject.transform.parent = null;
                holdableObject.GetComponent<Holdable>().holder = null;
                isHolding = false;
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (isHolding)
            {
                holdableObject.GetComponent<Rigidbody>().AddForce(this.transform.forward * throwForce, ForceMode.Impulse);
                holdableObject.transform.parent = null;
                holdableObject.GetComponent<Holdable>().holder = null;
                isHolding = false;
            }
        }
    }
}
