using System.Collections;
using UnityEngine;

public class DestroyParticle : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(DelayDestroy());
    }

    private IEnumerator DelayDestroy()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}