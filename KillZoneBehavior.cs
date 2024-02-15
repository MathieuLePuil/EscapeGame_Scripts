using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class KillZoneBehavior : MonoBehaviour
{
    public GameObject donuts1;
    public GameObject donuts2;
    public GameObject endScreen;
    public Rigidbody doorRigidbody;
    public AudioClip sound;
    private AudioSource audioSource;

    public void Start()
    {
        endScreen.SetActive(false);
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component not found on the object!");
        }
    }

    public void OnPlayerWin()
    {
        endScreen.SetActive(true);
        doorRigidbody.constraints = RigidbodyConstraints.None;

        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("Audiosource manquante");
        }
    }

    void OnTriggerEnter(Collider col) {
        GameObject colliderGo = col.gameObject;

        if (colliderGo == donuts1 | colliderGo == donuts2) {
            OnPlayerWin();
        }
    }
}
