using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

public class PhysicsTriggers : MonoBehaviour
{

    public UnityEvent OnTriggerEnterEvent = new UnityEvent();

    private void OnTriggerEnter(Collider other)
    {
        OnTriggerEnterEvent.Invoke();
    }

}
