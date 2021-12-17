using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class GameMusic : MonoBehaviour
{
    public const int EXPLOSION_SOUND = 0;

    //each game character should have a unique audio list
    [SerializeField] private List<AudioClip> audioClips;
    public AudioSource audioSource;




    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();

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
