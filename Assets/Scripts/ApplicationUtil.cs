using UnityEngine;

public class ApplicationUtil : MonoBehaviour
{
    // Setting up a Application Utility Interface for Detecting the Platform
    public static RuntimePlatform platform
    {
        get
        {
        #if UNITY_ANDROID
            return RuntimePlatform.Android;
        #elif UNITY_IOS
                 return RuntimePlatform.IPhonePlayer;
        #elif UNITY_STANDALONE_OSX
                 return RuntimePlatform.OSXPlayer;
        #elif UNITY_STANDALONE_WIN
                 return RuntimePlatform.WindowsPlayer;
        #endif
        }
    }
}