using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private string sceneToLoad;

    #region Public methods
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
    #endregion
}
