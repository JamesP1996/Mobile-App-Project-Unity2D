using UnityEngine;

public class ShootButton : MonoBehaviour
{
    // If The Platform the Application is Android. Show the Button. If it's not, Dont.
    private void Update()
    {
        if (ApplicationUtil.platform == RuntimePlatform.Android || ApplicationUtil.platform == RuntimePlatform.OSXPlayer)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}