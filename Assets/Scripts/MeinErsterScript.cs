using UnityEngine;

public class MeinErsterScript : MonoBehaviour
{
    public Light lightTarget;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {   
            // Als Tipp für neue Aufgabe!
            lightTarget.color = Color.red;
            // ==========================
            lightTarget.intensity += 10.0f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            lightTarget.intensity -= 10.0f * Time.deltaTime;
        }
    }

    public void SpawnRandomCube()
    {
        GameObject newGo = GameObject.CreatePrimitive(PrimitiveType.Cube);
        newGo.transform.position = Random.insideUnitSphere * 2.0f;

    }
}
