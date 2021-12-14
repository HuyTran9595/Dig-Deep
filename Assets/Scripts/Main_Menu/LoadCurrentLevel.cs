using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadCurrentLevel : MonoBehaviour
{
    public void LoadCurLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
