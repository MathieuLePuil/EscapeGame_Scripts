using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class LockBehavior : MonoBehaviour
{
    public GameObject door;
    public GameObject paper;
    private XRGrabInteractable grabInteractable;
    public Rigidbody doorRigidbody;
    public GameObject textDonuts;
    public GameObject KillZone;
    private BoxCollider killZoneCollider;
    public TMP_Text screenText;
    public GameObject TVScreen;

    void Start()
    {
        textDonuts.SetActive(false);
        KillZone.SetActive(false);
        TVScreen.SetActive(false);

        killZoneCollider = KillZone.GetComponent<BoxCollider>();
        if (killZoneCollider == null)
        {
            Debug.LogError("BoxCollider component not found on the KillZone object!");
        }
        else
        {
            killZoneCollider.isTrigger = false;
        }

        grabInteractable = door.GetComponent<XRGrabInteractable>();

        if (paper.GetComponent<XRGrabInteractable>() != null)
        {
            paper.GetComponent<XRGrabInteractable>().enabled = false;
        }
        else
        {
            Debug.LogError("XRGrabInteractable component not found on the door object!");
        }

        if (grabInteractable != null)
        {
            grabInteractable.enabled = false;
        }
        else
        {
            Debug.LogError("XRGrabInteractable component not found on the door object!");
        }

        Invoke("ActivateScreenText", 60f);
    }

    void ActivateScreenText()
    {
        TVScreen.SetActive(true);
    }

    void UpdateText()
    {
        screenText.text = "Vous n'avez pas une petite faim ?";
    }
    public void openDoor()
    {
	    doorRigidbody.constraints = RigidbodyConstraints.None;
	    textDonuts.SetActive(true);
	    KillZone.SetActive(true);
	    if (killZoneCollider != null)
        {
            killZoneCollider.isTrigger = true;
        }
        if (grabInteractable != null)
        {
            grabInteractable.enabled = true;
        }
        if (paper.GetComponent<XRGrabInteractable>() != null)
        {
            paper.GetComponent<XRGrabInteractable>().enabled = true;
        }
        Invoke("UpdateText", 60f);
    }
}
