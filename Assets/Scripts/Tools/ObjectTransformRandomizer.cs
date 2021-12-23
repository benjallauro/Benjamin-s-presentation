using UnityEngine;

public class ObjectTransformRandomizer : MonoBehaviour
{
    [SerializeField] private float minHeight;
    [SerializeField] private float maxHeight;
    [SerializeField] private bool randomizeHeight;
    [SerializeField] private bool randomizeRotation;

    #region Unity methods
    private void Start()
    {
        if(randomizeHeight)
            this.transform.position = new Vector3(this.transform.position.x, Random.Range(minHeight, maxHeight), this.transform.position.z);
        if(randomizeRotation)
        {
            Vector3 euler = transform.eulerAngles;
            euler.x = Random.Range(0f, 360f); euler.y = Random.Range(0f, 360f); euler.z = Random.Range(0f, 360f);
            transform.eulerAngles = euler;
        }
    }
    #endregion
}
