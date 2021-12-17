using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject explosion;
    GameMusic gameMusic;
    private void Start()
    {
        door.SetActive(false);
        gameMusic = GameObject.FindWithTag("Sound Manager").GetComponent<GameMusic>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "BluePotion")
        {
            explosion.SetActive(true);
            gameMusic.PlaySound(GameMusic.EXPLOSION_SOUND);
            door.SetActive(true);
            StartCoroutine(DestroyThis(0.5f));
        } 
    }


    IEnumerator DestroyThis(float sec)
    {
        yield return new WaitForSeconds(sec);
        Destroy(this.gameObject);
    }
}
