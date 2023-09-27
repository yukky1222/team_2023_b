using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObject : MonoBehaviour
{
    public string tagCondition;
    public delegate void OnTriggerDelegate(Transform transform);
    public OnTriggerDelegate OnTriggerEnterDelegate;
    public OnTriggerDelegate OnTriggerExitDelegate;

    private void OnTriggerEnter(Collider other)
    {
        if (string.IsNullOrEmpty(tagCondition) || other.tag == tagCondition)
        {
            OnTriggerEnterDelegate?.Invoke(other.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (string.IsNullOrEmpty(tagCondition) || other.tag == tagCondition)
        {
            OnTriggerExitDelegate?.Invoke(other.transform);
        }
    }
}