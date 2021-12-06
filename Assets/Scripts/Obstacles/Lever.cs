using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] GameObject lockPosition;
    [SerializeField] GameObject openPosition;

    public bool isOpened = false;

    Level_1_GameManager level_1_GameManager;

    private void Start()
    {
        if (!isOpened)
        {
            lockPosition.SetActive(true);
            openPosition.SetActive(false);
        }
        else
        {
            Debug.Log("This lever is opened at the beginning of the game?");
        }

        level_1_GameManager = GameObject.FindWithTag("Level_1_GameManager").GetComponent<Level_1_GameManager>();
    }
    public void OpenLever()
    {
        isOpened = true;
        lockPosition.SetActive(false);
        openPosition.SetActive(true);
        level_1_GameManager.OnLeverOpen();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Player enter");
            OpenLever();
        }
    }

}
