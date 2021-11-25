using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Camera : MonoBehaviour
{
    Quaternion Dir;
    bool right;
    bool left;
    [SerializeField]
    float speed;
    float angle;

    // Start is called before the first frame update
    void Start()
    {
        right = false;
        left = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (right == true || left == true)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Dir, Time.deltaTime * speed);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            angle = angle - 90f;
            Dir = Quaternion.Euler(0, angle, 0);
            left = false;
            right = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            angle = angle + 90f;
            Dir = Quaternion.Euler(0, angle, 0);
            right = false;
            left = true;
        }
    }

    void FixedUpdate()
    {
        
    }
}
