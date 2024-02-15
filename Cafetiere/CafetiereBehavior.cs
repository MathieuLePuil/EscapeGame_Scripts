using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CafetiereBehaviour : MonoBehaviour
{
    public GameObject CafetiereButton;

    void Start()
    {
    	CafetiereButton.SetActive(false);
    }

    public void ShowCafetiereButton()
    {
    	CafetiereButton.SetActive(true);
    }
}