using UnityEngine;

public class TorTrigger : MonoBehaviour
{
    public GameObject tor;
    public Light alarmLicht;
    public Light alarmLicht2;
    private void OnTriggerEnter(Collider other)
    {
        tor.SetActive(false);
        alarmLicht.color = Color.green;
        alarmLicht2.color = Color.yellow;
    }
}
