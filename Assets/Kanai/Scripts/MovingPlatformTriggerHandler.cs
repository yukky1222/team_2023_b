using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformTriggerHandler : MonoBehaviour
{
    const string kPlayer = "Player";
    const string kBox = "Box";

    [SerializeField]
    Transform geometry;
    [SerializeField]
    TriggerObject playerTrigger;
    [SerializeField]
    TriggerObject boxTrigger;

    private void Start()
    {
        playerTrigger.tagCondition = kPlayer;
        playerTrigger.OnTriggerEnterDelegate = OnTriggerPlayerEnterCallback;
        playerTrigger.OnTriggerExitDelegate = OnTriggerPlayerExitCallback;

        boxTrigger.tagCondition = kBox;
        boxTrigger.OnTriggerEnterDelegate = OnTriggerBoxEnterCallback;
        boxTrigger.OnTriggerExitDelegate = OnTriggerBoxExitCallback;
    }

    void OnTriggerPlayerEnterCallback(Transform other)
    {
        Debug.Log("OnTriggerPlayerEnterCallback");
        other.SetParent(transform);
    }

    void OnTriggerPlayerExitCallback(Transform other)
    {
        Debug.Log("OnTriggerPlayerExitCallback");
        other.SetParent(null);
    }

    void OnTriggerBoxEnterCallback(Transform other)
    {
        Debug.Log("OnTriggerBoxEnterCallback");
        other.SetParent(transform);
    }

    void OnTriggerBoxExitCallback(Transform other)
    {
        Debug.Log("OnTriggerBoxExitCallback");
        other.SetParent(geometry);
    }
}