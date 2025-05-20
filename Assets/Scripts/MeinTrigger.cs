using UnityEngine;

public class MeinTrigger : MonoBehaviour
{
    public Light otherLight;
    private void OnTriggerEnter(Collider other)
    {

        // Nicht so gut!
        if(other.gameObject.name == "PLAYER")
        {

        }

        // bessere methode.
        if (other.gameObject.CompareTag("Player"))
        {

        }

        // auch gut!
        if (other.gameObject.GetComponent<Bewegung2>())
        {
            otherLight.intensity += 10.0f;

        }



    }
}
