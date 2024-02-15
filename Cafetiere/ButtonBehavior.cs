using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class ImprimanteBehaviour : MonoBehaviour
{
    public TMP_Text screenText;
    public bool isPrinting;
    public GameObject printButton;
    public GameObject keyObject;
    public AudioClip sound;
    private AudioSource audioSource;

    void Start()
    {
        printButton.SetActive(false);
        keyObject.SetActive(false);

	audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component not found on the object!");
        }
    }

    public void StartPrinting()
    {
        if (!isPrinting)
        {
            screenText.text = "Wait";
            isPrinting = true;
            ShowKeyObject();
        }
    }

    public void ShowPrintButton()
    {
        printButton.SetActive(true);
    }

    void ShowKeyObject()
    {
        keyObject.SetActive(true);

	if (audioSource != null && audioSource.clip != null) 
	{
	    audioSource.Play();
	}
	else
	{
	    Debug.LogWarning("Audiosource manquante");
	}

        Rigidbody keyRigidbody = keyObject.GetComponent<Rigidbody>();
        if (keyRigidbody != null)
        {
            keyRigidbody.useGravity = true;
            keyRigidbody.isKinematic = false;
        }

        var grabbable = keyObject.GetComponent<XRGrabInteractable>();
        if (grabbable != null)
        {
            grabbable.enabled = true;
        }


    }
}
