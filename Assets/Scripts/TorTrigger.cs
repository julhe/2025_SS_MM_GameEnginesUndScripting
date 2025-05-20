using UnityEngine;

public class TorTrigger : MonoBehaviour
{
    public GameObject tor;
    public Light alarmLicht;
    private void OnTriggerEnter(Collider other)
    {
        tor.SetActive(false);
        alarmLicht.color = Color.green;
    }
}
