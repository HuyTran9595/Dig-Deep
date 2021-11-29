using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCanvas : MonoBehaviour
{
    [SerializeField] Canvas GameMenuCanvas;

    private void Start()
    {
        GameMenuCanvas.gameObject.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameMenuCanvas != null)
            {
                if (GameMenuCanvas.gameObject.activeSelf)
                {
                    GameMenuCanvas.gameObject.SetActive(false);
                }
                else
                {
                    GameMenuCanvas.gameObject.SetActive(true);
                }
            }
        }
    }
}
