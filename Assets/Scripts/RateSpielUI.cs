using TMPro;
using UnityEngine;

public class RateSpielUI : MonoBehaviour
{
    public TextMeshProUGUI textTarget; // NEU!
    public Light lightTarget;
    public void RateEineZahl(int zahl)
    {
        bool richtigGeraten = zahl == Random.Range(1, 4);
        if (richtigGeraten)
        {
            textTarget.text = "Du hast richtig geraten!"; // NEU!
            lightTarget.color = Color.green;
        }
        else
        {
            textTarget.text = "Das war leider falsch!"; //NEU!
            lightTarget.color = Color.red;
        }
    }
}
