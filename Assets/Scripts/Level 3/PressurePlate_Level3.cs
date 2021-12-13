using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate_Level3 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject Blockage1;
    [SerializeField] GameObject Blockage2;

    [SerializeField] int totalWeightToUnlock = 20;
    int totalWeight = 0;
    bool isUnlocked = false;
    public List<Weight_Level3> weights;

    private void Start()
    {
        Blockage1 = GameObject.FindWithTag("Blockage 1");
        Blockage2 = GameObject.FindWithTag("Blockage 2");

        if(Blockage1 is null)
        {
            Debug.Log("Cannot find blockage 1");
        }
        if (Blockage2 is null)
        {
            Debug.Log("Cannot find blockage 2");
        }
        weights = new List<Weight_Level3>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Weight_Level3 weight = other.gameObject.GetComponent<Weight_Level3>();
        if (weight is null)
        {
            return;
        }
        else
        {
            weights.Add(weight);
            Recalcute();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Weight_Level3 weight = other.gameObject.GetComponent<Weight_Level3>();
        if (weight is null)
        {
            return;
        }
        else
        {
            weights.Remove(weight);
            Recalcute();
        }
    }




    private void Recalcute()
    {
        totalWeight = 0;
        foreach(Weight_Level3 weight in weights)
        {
            totalWeight += weight.GetWeight();
        }
       //Debug.Log("Total weight is " + totalWeight);
        
        if(totalWeight >= totalWeightToUnlock && !isUnlocked)//we unlock
        {
            Blockage1.GetComponent<BlockageLerp>().ChangeStatus();
            Blockage2.GetComponent<BlockageLerp>().ChangeStatus();
            isUnlocked = true;
            //Debug.Log("isUnlocked = " + isUnlocked);
            return;
        }

        if(totalWeight < totalWeightToUnlock && isUnlocked)
        {
            Blockage1.GetComponent<BlockageLerp>().ChangeStatus();
            Blockage2.GetComponent<BlockageLerp>().ChangeStatus();
            isUnlocked = false;
           // Debug.Log("isUnlocked = " + isUnlocked);
            return;
        }


    }
}
