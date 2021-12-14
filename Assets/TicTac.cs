using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTac : MonoBehaviour
{
    public TriggerCheck[] triggerBoxs;
    public GameObject door;
    public GameObject wall;
    public GameObject barrel;

    public bool active;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((triggerBoxs[0].cross && triggerBoxs[1].cross)|| (triggerBoxs[3].cross && triggerBoxs[6].cross)|| (triggerBoxs[2].cross && triggerBoxs[4].cross))
        {
            if (!active)
            {
                door.SetActive(false);
                active = true;
            }

        }
        else
        {
            door.SetActive(true);
            active = false;
        }

        //if (triggerBoxs[3].cross && triggerBoxs[6].cross)
        //{
        //    if (!active)
        //    {
        //        door.SetActive(false); 
        //        active = true;
        //    }
        //}
        //else
        //{
        //    door.SetActive(true);
        //    active = false;
        //}

        //if (triggerBoxs[2].cross && triggerBoxs[4].cross)
        //{
        //    if (!active)
        //    {
        //        door.SetActive(false);
        //        active = true;
        //    }
        //}
        //else
        //{
        //    door.SetActive(true);
        //    active = false;
        //}

        if ((triggerBoxs[0].circle && triggerBoxs[4].circle)||(triggerBoxs[2].circle && triggerBoxs[3].circle))
        {
            Destroy(wall);
            Destroy(barrel);
        }

        //if (triggerBoxs[2].circle && triggerBoxs[3])
        //{
        //    Destroy(wall);
        //    Destroy(barrel);
        //}

    }
}
