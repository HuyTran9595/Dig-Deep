using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    Vector3 Move_Dir;
    [SerializeField]
    float Speed;
    Rigidbody rb;
    [SerializeField]
    float Jump_Speed;

    CharacterController Controller;

    float Hor;
    float Ver;

    GameObject Cam_Target;

    [SerializeField]
    float S_Time;
    [SerializeField]
    float Turn_Speed;


    // Start is called before the first frame update
    void Start()
    {
        Controller = gameObject.GetComponent<CharacterController>();
        rb = gameObject.GetComponent<Rigidbody>();
        Cam_Target = GameObject.Find("Cam_Target");
    }

    // Update is called once per frame
    void Update()
    {
        Hor = Input.GetAxisRaw("Horizontal");
        Ver = Input.GetAxisRaw("Vertical");
        Move_Dir = new Vector3(Hor, 0, Ver).normalized;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * Jump_Speed, ForceMode.Impulse);
        }

        if (Move_Dir.magnitude >= 0.1f)
        {
            float Tar_Angle = Mathf.Atan2(Move_Dir.x, Move_Dir.z) * Mathf.Rad2Deg + Cam_Target.transform.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, Tar_Angle, ref Turn_Speed, S_Time);
            transform.rotation = Quaternion.Euler(0, angle, 0);

            Vector3 New_Move_Dir = Quaternion.Euler(0, Tar_Angle, 0) * Vector3.forward;
            Controller.Move(New_Move_Dir.normalized * Speed * Time.deltaTime);
        }
    }

    void FixedUpdate()
    {
        
    }
}
