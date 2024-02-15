using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class PanicButton : MonoBehaviour
{
	public bool isOn  = false;
//	public float pushDistance = 0.1f;
//    private Vector3 initialPosition;
//
//    void Start()
//    {
//        initialPosition = transform.localPosition;
//    }

	public void ToggleSwitch()
	{
		if (!isOn)
		{
			isOn = true;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
//            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - pushDistance, transform.localPosition.z);
		}
	}
}