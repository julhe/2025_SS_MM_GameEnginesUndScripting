using UnityEngine;

public class ImpactSound : MonoBehaviour
{
    AudioSource impactSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        impactSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        impactSound.Play();
    }
}
