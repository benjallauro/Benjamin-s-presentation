using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInfo : MonoBehaviour
{
    [SerializeField] private string floorTag;
    private bool triggerDetected = false;

    #region Unity methods
    public bool GetTriggerDetected()
    {
        return triggerDetected;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == floorTag)
        {
            triggerDetected = true;
        }
    }
    #endregion
}
