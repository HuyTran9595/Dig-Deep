using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]
public class BackgroundMusic : MonoBehaviour
{
    public const int BACKGROUND_LEVEL1 = 0;
    public const int BACKGROUND_LEVEL3 = 1;
    public const int BACKGROUND_LEVEL2 = 2;
    public const int BACKGROUND_LEVEL4 = 3;

    //each game character should have a unique audio list
    [SerializeField] private List<AudioClip> audioClips;
    public AudioSource audioSource;




    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        if (SceneManager.GetActiveScene().name == "Level 1")
        {
            PlaySound(BACKGROUND_LEVEL1);
        }
        if (SceneManager.GetActiveScene().name == "Level 3")
        {
            PlaySound(BACKGROUND_LEVEL3);
        }
        if (SceneManager.GetActiveScene().name == "Level 2")
        {
            PlaySound(BACKGROUND_LEVEL2);
        }
        if (SceneManager.GetActiveScene().name == "Level 4")
        {
            PlaySound(BACKGROUND_LEVEL4);
        }

    }

    /// <summary>
    /// Play the sound based on index in audioClips list
    /// If index error, print error and play nothing
    /// </summary>
    /// <param name="soundIndex"></param>
    public void PlaySound(int soundIndex)
    {
        //index out of range
        if (soundIndex < 0 || soundIndex >= audioClips.Count)
        {
            Debug.LogError("Sound index out of range in : " + name);
            return;
        }

        audioSource.clip = audioClips[soundIndex];
        Debug.Log("Current sound: " + audioSource.clip.name);
        audioSource.Play();
    }
}
