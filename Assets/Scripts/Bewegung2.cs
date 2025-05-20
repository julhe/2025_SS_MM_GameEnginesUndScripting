using UnityEngine;

public class Bewegung2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        CharacterController controller = GetComponent<CharacterController>();

        controller.SimpleMove(movement * 10.0f);

    }
}
