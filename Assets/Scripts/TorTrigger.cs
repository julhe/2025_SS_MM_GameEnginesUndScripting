using UnityEngine;

public class TorTrigger : MonoBehaviour
{
    public GameObject tor;
    public Light alarmLicht;
    public Light alarmLicht2;



    // Speichert ob man schon mit diesem Trigger interagiert hat.
    bool hasInteracted = false;

  
    public GameObject player; // Hier kommt der spieler rein
    public void OnInteraction()
    {
        hasInteracted = true;   
        tor.SetActive(false);
        alarmLicht.color = Color.green;
        alarmLicht2.color = Color.yellow;


        // Erhöht die größe des player transformes um 100%
        player.transform.localScale += Vector3.one;
    }

    public void OnIsInteractable()
    {
        // Man soll nur die Interaktionsmöglichkeit angezeigt bekommen, wenn man noch nicht mit dem Objekt interagiert hat.
        if(hasInteracted)
        {
            // Wir HABEN schon interagiert, keine weitere Interaktion soll passieren.
            InteractionSensor.NextObjectCanInteract = false;

        } else
        {
            // Wir haben NOCH NICHT interagiert, weitere Interaktion soll möglich sein.
            InteractionSensor.NextObjectCanInteract = true;
        }
    }
}
