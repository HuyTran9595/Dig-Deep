using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevelButton : MonoBehaviour
{
    [SerializeField] string NextLevelName;
    [SerializeField] GameObject nextLevelButton;


    GameData gameData;
    private void Start()
    {
        gameData = GameObject.Find("GameData").GetComponent<GameData>();
        if (gameData is null)
        {
            Debug.Log("Cannot find game data");
        }

        if (gameData.lastSceneOpened == "Level 1")
        {
            NextLevelName = "Level 2";
        }
        if (gameData.lastSceneOpened == "Level 2")
        {
            NextLevelName = "Level 3";
        }
        if (gameData.lastSceneOpened == "Level 3")
        {
            NextLevelName = "Level 4";
        }
        if (gameData.lastSceneOpened == "Level 4")
        {
            gameObject.SetActive(false);
        }

    }

    public void NextLevelButtonClicked()
    {
        SceneManager.LoadScene(NextLevelName);
    }


}
