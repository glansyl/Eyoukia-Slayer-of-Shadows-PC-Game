using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    /// <summary>
    /// Loads a scene by its name.
    /// </summary>
    /// <param name="sceneName">The name of the scene to load.</param>
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    /// <summary>
    /// Loads a scene by its index in the Build Settings.
    /// </summary>
    /// <param name="sceneIndex">The index of the scene to load.</param>
    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void DisablePanel(GameObject panelToDisable)
    {
        panelToDisable.SetActive(false);
    }

    public void EnablePanel(GameObject panelToEnable)
    {
        panelToEnable.SetActive(true);
    }

    /// <summary>
    /// Reloads the current active scene.
    /// </summary>
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    /// <summary>
    /// Quits the game (only works in a built application).
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting..."); // Won't show in a built game but useful in the editor
    }
}
