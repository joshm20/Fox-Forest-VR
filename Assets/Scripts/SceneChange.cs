using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("CityFinal");
            SceneManager.UnloadSceneAsync("Meadow");

        }
    }
}
