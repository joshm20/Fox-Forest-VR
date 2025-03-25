using UnityEngine;
using UnityEngine.Events;

public class WaterTrigger : MonoBehaviour
{

    public UnityEvent onEnter;
    public UnityEvent onExit;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onEnter.Invoke();
        }
    }
}
