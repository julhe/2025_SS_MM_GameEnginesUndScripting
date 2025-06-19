using UnityEngine;

public class Bewegung2 : MonoBehaviour
{
    Vector3 postitonLastFrame;
    float walkedDistance;
    public float walkDistanceForSound = 2.0f;
    public AudioSource walkSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        postitonLastFrame = transform.position;
    }

   
    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        CharacterController controller = GetComponent<CharacterController>();

        controller.SimpleMove(movement * 10.0f);


        Vector3 positionThisFrame = transform.position;
        walkedDistance += Vector3.Distance(positionThisFrame, postitonLastFrame);
        postitonLastFrame = positionThisFrame;
        if(walkedDistance > walkDistanceForSound)
        {
            // spiele sound ab.
            walkedDistance = 0.0f;
            walkSound.pitch = Random.Range(0.9f, 1.1f);
            walkSound.Play();
        }
    }
}
