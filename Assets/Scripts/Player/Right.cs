using UnityEngine;

public class Right : MonoBehaviour
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

    // On the Right Movement UI Button if the button is being held. Move Right, Else Don't Move.
    public void OnPointerDown()
    {
        PlayerMovement.buttonDownRight = true;
    }

    public void OnPointerUp()
    {
        PlayerMovement.buttonDownRight = false;
    }
}