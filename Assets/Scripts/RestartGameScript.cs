using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGameScript : MonoBehaviour
{
    public void restartGame()
    {
        SceneManager.LoadScene("Meadow");
        SceneManager.UnloadSceneAsync("CityFinal");
    }
}
