using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Pull : MonoBehaviour
{
    [SerializeField] bool isPulling = false;
    [SerializeField] Pullable beingPulled;
    [SerializeField] float pullCancelDistance;

    private void Update()
    {

        //switch pulling mode
        if(Input.GetKeyDown(KeyCode.E)){
            isPulling = !isPulling;
            //Debug.Log("is pulling = " + isPulling);

            if (!isPulling)//we just cancel pulling
            {
                if(beingPulled != null)
                {
                    beingPulled.OnPullingFinished();
                    beingPulled = null;
                }
            }
        }

        EndPullCheck();

    }

    //if pulling obj fall off, stop pulling
    private void EndPullCheck()
    {
        if(beingPulled == null)
        {
            return;
        }
        float distance = Vector3.Distance(transform.position, beingPulled.transform.position);
        //Debug.Log(distance);
        if(distance >= pullCancelDistance)
        {
            beingPulled.OnPullingFinished();
            beingPulled = null;
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (!isPulling)
        {
            return;
        }
        else if( beingPulled != null)
        {
            return;
        }
        else
        {
            Pullable pullable = hit.gameObject.GetComponent<Pullable>();
            if(pullable != null)
            {
                beingPulled = pullable;
                beingPulled.OnPulling(this.gameObject);
            }
        }
    }

    public bool IsPulling()
    {
        return isPulling;
    }

}
