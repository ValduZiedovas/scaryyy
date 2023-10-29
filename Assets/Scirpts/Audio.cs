using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject[] objectsToAppear;

    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();

        // Uzfiksuoja, kada baigsis audi clip
        StartCoroutine(ActivateObjectsAfterClipEnds());
    }

    private IEnumerator ActivateObjectsAfterClipEnds()
    {
        yield return new WaitForSeconds(audioSource.clip.length);
        
        // aktyvuoja pasirinktus gameobjects.
        foreach (GameObject obj in objectsToAppear)
        {
            obj.SetActive(true);
        }
    }
}
