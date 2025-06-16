using UnityEngine;

public class IncreaseSizeOnInteract : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public GameObject player;

    public void OnInteraction()
    {
        player.transform.localScale += Vector3.one;
    }

    public void OnIsInteractable()
    {
        InteractionSensor.NextObjectCanInteract = true;  
    }
}
