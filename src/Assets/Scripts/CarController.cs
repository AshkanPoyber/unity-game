using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 50f;
    public AudioSource gasSound;

    void Update()
    {
        float move = 0f;

        // Check for movement and play sound
        if (Input.GetKey(KeyCode.W))
        {
            move = speed * Time.deltaTime;

            // Play gas sound if it's not already playing
            if (!gasSound.isPlaying)
            {
                gasSound.Play();
            }
        }
        else
        {
            // Stop the gas sound when W is released
            if (gasSound.isPlaying)
            {
                gasSound.Stop();
            }
        }
        // Move forward and backward
        move = Input.GetAxis("Vertical") * speed * Time.deltaTime * -1;
        transform.Translate(0, 0, move);

        // Turn left and right
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        transform.Rotate(0, turn, 0);
    }
}
