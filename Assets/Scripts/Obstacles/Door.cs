using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Door : MonoBehaviour
{
    GameData gameData;
    private void Start()
    {
        gameData = GameObject.Find("GameData").GetComponent<GameData>();
        if(gameData is null)
        {
            Debug.Log("Cannot find game data");
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("Player found the door.");
            WinLevelSequence();
        }
    }

    private void WinLevelSequence()
    {
        gameData.lastSceneOpened = SceneManager.GetActiveScene().name;
        StartCoroutine(LoadWinScene());
    }

    IEnumerator LoadWinScene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Win_scene");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            WinLevelSequence();
        }
    }
}
