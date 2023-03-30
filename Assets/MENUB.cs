using UnityEngine;
using UnityEngine.SceneManagement;

public class MENUB : MonoBehaviour
{
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}