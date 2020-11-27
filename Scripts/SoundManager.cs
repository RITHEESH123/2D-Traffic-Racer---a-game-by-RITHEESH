using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(TurnOnAccelertion());
    }

    IEnumerator TurnOnAccelertion()
    {
        yield return new WaitForSeconds(5f);
        audioSource.Play();
    }
}
