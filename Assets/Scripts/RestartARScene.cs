using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class RestartARScene : MonoBehaviour
{
    ARSession arSession;

    void Start()
    {
        arSession = FindObjectOfType<ARSession>();

        // Add a listener to the button click event
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(RestartScene);
    }

    void RestartScene()
    {
        // Reset AR session
        if (arSession != null)
        {
            arSession.Reset();
        }

    }
}
