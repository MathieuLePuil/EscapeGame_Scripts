using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class Chair : MonoBehaviour
{
    public TMP_Text screenText;

    void UpdateText()
    {
        screenText.text = "Beurk ! Jetez moi ça !";
    }

    public void OnGrabChair()
    {
        Invoke("UpdateText", 60f);
    }
}
