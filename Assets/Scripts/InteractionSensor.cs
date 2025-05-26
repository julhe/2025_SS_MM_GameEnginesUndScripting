using UnityEngine;

public class InteractionSensor : MonoBehaviour
{
    // Globaler Bool, der aus OnIsInteractable() gesetzt wird, um zu sagen, ob wir mit dem Objekt interagieren könnne. //
    
    // (Hinweis: das ist nicht die eleganteste oder schönste Methode und in einem größerem Projekt nicht so gerne gesehen, aber sie wird erstmal für unsere Zwecke reichen...)
    public static bool NextObjectCanInteract = false; 

    // Das GameObject das wir anzeigen, wenn wir interagieren können.
    public GameObject InteractionIndicator;

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(
            transform.position, // Start Punkt des Ray-Casts
            transform.forward,  // Richtung des Ray-Casts
            out RaycastHit hit, // Speicherpunkt des Ergebnisses des Ray-Casts
            5.0f, // Maximal Distanz des Ray-Casts
            ~LayerMask.GetMask("Player"), // Welcher Layer überprüft werden soll. Siehe: https://docs.unity3d.com/6000.1/Documentation/Manual/layermask-introduction.html
            QueryTriggerInteraction.UseGlobal // Wie sollen Trigger behandelt werden?
            )
        ) 
        {
            // Ein Objekt ist vor uns!

            NextObjectCanInteract = false;
            // Sende die OnIsInteractable Nachricht. Wenn das Objekt interagieren kann, wird es NextObjectCanInteract auf true setzen.
            hit.transform.gameObject.SendMessage("OnIsInteractable", SendMessageOptions.DontRequireReceiver);

            // Zeige den InteractionIndicator.
            InteractionIndicator.SetActive(NextObjectCanInteract);
            if (Input.GetKeyDown(KeyCode.E))
            {
                // Sende die OnInteraction Nachricht, um zu sagen das wir Interagieren wollen.
                hit.transform.gameObject.SendMessage(
                    "OnInteraction", 
                    SendMessageOptions.DontRequireReceiver
                );

            
            }
            Debug.Log(hit.transform.name);
        } else
        {
            // Kein Objekt vor uns! 
            // Verstecke den InteractionIndicator.
            InteractionIndicator.SetActive(false);
        }
        
    }
}
