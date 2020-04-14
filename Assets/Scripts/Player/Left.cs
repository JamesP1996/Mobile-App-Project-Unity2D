using UnityEngine;

public class Left : MonoBehaviour
{
    private void Update()
    {
        // Check if Platform is a Mobile Platform and Then Set Button Active or Unactive.
        if (ApplicationUtil.platform == RuntimePlatform.Android || ApplicationUtil.platform == RuntimePlatform.OSXPlayer)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    // On the Left Movement UI Button if the button is being held. Move Left, Else Don't Move.
    public void OnPointerDown()
    {
        PlayerMovement.buttonDownLeft = true;
    }

    public void OnPointerUp()
    {
        PlayerMovement.buttonDownLeft = false;
    }
}