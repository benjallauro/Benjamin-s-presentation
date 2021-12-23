using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;

    #region Unity methods
    void Update()
    {
        transform.LookAt(target);
    }
    #endregion
}
