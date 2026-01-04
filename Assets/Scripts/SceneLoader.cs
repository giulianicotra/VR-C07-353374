using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene("Environment", LoadSceneMode.Additive);
        SceneManager.LoadScene("Props", LoadSceneMode.Additive);
        SceneManager.LoadScene("Lighting", LoadSceneMode.Additive);
        SceneManager.LoadScene("Audio", LoadSceneMode.Additive);
    }
}