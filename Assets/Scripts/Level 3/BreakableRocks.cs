using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableRocks : MonoBehaviour
{
    [SerializeField] GameObject[] breakableRocks;
    [SerializeField] GameObject explosion;
    GameMusic gameMusic;

    private void Start()
    {
        gameMusic = GameObject.FindWithTag("Sound Manager").GetComponent<GameMusic>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ExplosivePotion")
        {
            explosion.SetActive(true);
            gameMusic.PlaySound(GameMusic.EXPLOSION_SOUND);
            foreach (GameObject breakableRock in breakableRocks)
            {
                Destroy(breakableRock);
            }
            Destroy(other.gameObject);
        }
        

    }
    IEnumerator DestroyThis(GameObject destroy, float sec)
    {
        yield return new WaitForSeconds(sec);
        Destroy(destroy);
    }
}
