using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    [SerializeField] string StartLevelName;
    [SerializeField] GameObject nextLevelButton;


    GameData gameData;
    private void Start()
    {
        gameData = GameObject.Find("GameData").GetComponent<GameData>();
        if (gameData is null)
        {
            Debug.Log("Cannot find game data");
        }

        if(gameData.lastSceneOpened != "Level 1")
        {
            //nextLevelButton.SetActive(false);
        }
        if(gameData.lastSceneOpened == "Level 2")
        {
            StartLevelName = gameData.lastSceneOpened;
        }

    }

    public void StartGameButtonClicked()
    {
        SceneManager.LoadScene(StartLevelName);
    }


}
