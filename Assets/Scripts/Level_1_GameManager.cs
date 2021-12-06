using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_1_GameManager : MonoBehaviour
{
    GameObject[] levers;
    GameObject water;
    GameObject underwater;

    private void Start()
    {
        levers = GameObject.FindGameObjectsWithTag("Lever");
        Debug.Log(levers.Length);
        water = GameObject.FindWithTag("Water");
        underwater = GameObject.FindWithTag("Underwater");

        underwater.SetActive(false);
        water.SetActive(true);
    }


    //return false if not all levers are opened -> continue playing.
    //return true if all are opened -> remove the water, activate the Underwater game objects.
    public bool OnLeverOpen()
    {
        foreach (GameObject lever in levers)
        {
            if (lever.GetComponent<Lever>().isOpened == false)
            {
                return false;
            }
        }
        Debug.Log("All levers are opened");

        StartCoroutine(DestroyWater(0.5f));
        
        return true;
    }

    IEnumerator DestroyWater(float sec)
    {
        yield return new WaitForSeconds(sec);
        Destroy(water.gameObject);
        underwater.SetActive(true);
    }
}
