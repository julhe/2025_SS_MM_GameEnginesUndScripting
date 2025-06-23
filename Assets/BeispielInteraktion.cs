using UnityEngine;

public class BeispielInteraktion : MonoBehaviour
{
    public void OnInteraction()
    {
        print("Hallo!");
    }

    public void OnIsInteractable()
    {
        InteractionSensor.NextObjectCanInteract = true;
    }
}
