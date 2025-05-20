using UnityEngine;

public class Bewegung1 : MonoBehaviour
{
    public float Speed;
    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        movement = movement.normalized;
        transform.Translate(movement * Time.deltaTime * Speed, Space.World);

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, 0, 10 * Time.deltaTime * Speed));
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 0, -10 * Time.deltaTime * Speed));
        }
    }
}
