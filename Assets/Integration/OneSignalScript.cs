using UnityEngine;
using OneSignalSDK;

public class OneSignalScript : MonoBehaviour
{
    void Start()
    {
        // Replace 'YOUR_ONESIGNAL_APP_ID' with your OneSignal App ID from app.onesignal.com
        OneSignal.Default.Initialize("a6c4e4b2-57ae-479b-94f3-89ea1231222b");
    }
}
