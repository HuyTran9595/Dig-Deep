using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockageLerp : MonoBehaviour
{
    bool isLerping = false;
    [SerializeField] bool isBlocking = true;
    float journeyLength = 1f; //lerp time 1 second
    float timeSinceStartLerping = 0f;
    float yBlockingPosition = 0f;
    float yNonBlockingPosition = -2.5f;

    Vector3 startPosition;
    Vector3 targetPosition;

    [SerializeField] Blockage1BoxCheck boxCheck;


    private void Update()
    {
        timeSinceStartLerping += Time.deltaTime;
        TestLerp();
        LerpPositions();
    }

    private void TestLerp()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            ChangeStatus();
        }
    }

    public void ChangeStatus()
    {
        if(boxCheck != null)
        {
            if (boxCheck.isCollided && !isBlocking)
            {
                return;
            }
        }

        isBlocking = !isBlocking;
        isLerping = true;
        timeSinceStartLerping = 0f;


        if (isBlocking)//we lerp from NON-Blocking TO  Blocking position
        {
            startPosition = new Vector3(transform.position.x, yNonBlockingPosition, transform.position.z);
            targetPosition = new Vector3(transform.position.x, yBlockingPosition, transform.position.z);
        }
        else//we lerp from Blocking TO  NON-Blocking position
        {
            startPosition = new Vector3(transform.position.x, yBlockingPosition, transform.position.z);
            targetPosition = new Vector3(transform.position.x, yNonBlockingPosition, transform.position.z);
        }
    }



    private void LerpPositions()
    {
        if (!isLerping)
        {
            return;
        }
        if(timeSinceStartLerping > journeyLength)
        {
            isLerping = false;
            return;
        }
        //Debug.Log("Lerping");
        float fractionOfJourney = timeSinceStartLerping / journeyLength;
        //we lerping
        transform.position = Vector3.Lerp(startPosition, targetPosition, fractionOfJourney);
    }
}
