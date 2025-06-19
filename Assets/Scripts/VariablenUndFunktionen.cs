using System.Collections.Generic;
using UnityEngine;

public class VariablenUndFunktionen : MonoBehaviour
{
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int meineZahl = 4;
        print(meineZahl);
        meineZahl = MultipliziereZahlMit2(meineZahl);
        print(meineZahl);
    }


    int MultipliziereZahlMit2(int zahl)
    {
        return zahl * 2;
    }

    

    private void Update()
    {
        // Erzeugt eine menge müll für den C# Gabage Collector -> schlechtere performaance
        List<int> meinMuell = new List<int>();
        for (int i = 0; i < 1000; i++)
        {
            meinMuell.Add((int) Random.value);
        }
    }
}
