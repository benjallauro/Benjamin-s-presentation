using UnityEngine;
using System;

public class SimulationManager : MonoBehaviour
{
    [SerializeField] private float secondsBeforeGravityOn;
    [SerializeField] private float secondsBeforeSimulationFinish;
    [SerializeField] private Rigidbody objectToSimulate;
    [SerializeField] private TriggerInfo triggerInfo;
    [SerializeField] private SceneLoader sceneLoader;
    private GameTime gravityTimer;
    private GameTime simulationFinishTimer;

    #region Unity methods
    private void Awake()
    {
        try
        {
            Physics.gravity = new Vector3(Physics.gravity.x, -PhysicsData.GetInstance().GetLocalGravitationalAcceleration(), Physics.gravity.z);
        }
        catch (Exception exc)
        {
            Debug.LogWarning("the gravity information couldn't be loaded. Using the default gravity information");
        };
        Debug.Log("Gravity: " + Physics.gravity.y);
    }

    void Start()
    {
        gravityTimer = new GameTime();
        simulationFinishTimer = new GameTime();
        gravityTimer.SetTimer(secondsBeforeGravityOn);
        gravityTimer.StartTimer();
    }

    void Update()
    {
        if(gravityTimer.Update(Time.deltaTime))
        {
            gravityTimer.StopAndReset();
            objectToSimulate.useGravity = true;
        }
        if(!simulationFinishTimer.GetStarted() && objectToSimulate.velocity == Vector3.zero && triggerInfo.GetTriggerDetected())
        {
            simulationFinishTimer.SetTimer(secondsBeforeSimulationFinish);
            simulationFinishTimer.StartTimer();
        }
        if(simulationFinishTimer.Update(Time.deltaTime))
        {
            simulationFinishTimer.StopAndReset();
            sceneLoader.LoadScene();
        }
    }
    #endregion
}