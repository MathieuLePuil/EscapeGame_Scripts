using UnityEngine;

public class GrabObject : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnGrab()
    {
        audioSource.Play();
    }
}
