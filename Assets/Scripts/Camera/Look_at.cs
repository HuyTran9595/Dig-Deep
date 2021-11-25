using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look_at : MonoBehaviour
{
    GameObject Tartget;

    // Start is called before the first frame update
    void Start()
    {
        Tartget = GameObject.Find("Cam_Target");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Tartget.transform);
    }
}
