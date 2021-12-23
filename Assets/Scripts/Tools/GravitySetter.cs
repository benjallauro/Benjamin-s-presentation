using UnityEngine;
using UnityEngine.UI;

public class GravitySetter : MonoBehaviour
{
    #region Public methods
    public void SetGravity(Text gravity)
    {
        PhysicsData.GetInstance().SetGravitationalAcceleration(gravity);
    }
    #endregion
}