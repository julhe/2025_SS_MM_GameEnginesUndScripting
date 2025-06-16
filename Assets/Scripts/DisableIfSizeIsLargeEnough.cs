using UnityEngine;

public class DisableIfSizeIsLargeEnough : MonoBehaviour
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
    public GameObject objectToDisable;
    public void OnInteraction()
    {
        if(player.transform.localScale.x >= 2.0f)
        {
            objectToDisable.SetActive(false);
        }
    }

    public void OnIsInteractable()
    {
        InteractionSensor.NextObjectCanInteract = true;
    }
}
