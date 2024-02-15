using UnityEngine;

public class KeyInSlot : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            Debug.Log("La clé a été insérée dans le support.");
        }
    }
}