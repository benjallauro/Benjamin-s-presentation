using UnityEngine;
using UnityEngine.UI;
using System;

public class PhysicsData : MonoBehaviour
{
    private float gravitationalAcceleration = 9.81f;
    static PhysicsData instance;

    #region Unity methods
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
    }
    #endregion

    #region Public methods
    public static PhysicsData GetInstance()
    {
        return instance;
    }
    public void SetGravitationalAcceleration(Text gravitationalAccelerationText)
    {
        try
        {
            this.gravitationalAcceleration = float.Parse(gravitationalAccelerationText.text);
            Debug.Log("Se guardó: " + gravitationalAcceleration);
        }
        catch (Exception exc)
        {
            Debug.Log("Parse error. Are you using numbers?  Error info: " + exc);
        }
    }

    public float GetLocalGravitationalAcceleration()
    {
        return gravitationalAcceleration;
    }
    #endregion
}