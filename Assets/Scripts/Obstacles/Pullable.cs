using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pullable : MonoBehaviour
{
    [SerializeField] GameObject puller;
    [SerializeField] GameObject originalParent;

    private void Start()
    {
        originalParent = transform.parent.gameObject;
    }

    public void OnPulling(GameObject puller)
    {
        this.puller = puller;
        float y = puller.transform.position.y + 180f;
        Vector3 lookAt = new Vector3(0f, y, 0f);
        puller.transform.LookAt(lookAt);

        StartCoroutine(ChangeParent(puller));

    }

    public void OnPullingFinished()
    {
        transform.parent = originalParent.transform;
    }

    IEnumerator ChangeParent(GameObject puller)
    {

        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();
        transform.parent = puller.transform;
    }
}
