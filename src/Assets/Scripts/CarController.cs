using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 50f;

    void Update()
    {
        // Move forward and backward
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime * -1;
        transform.Translate(0, 0, move);

        // Turn left and right
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        transform.Rotate(0, turn, 0);
    }
}
