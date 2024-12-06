using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform car;        // Reference to the car (drag and drop the car object here in the Inspector)
    public Vector3 offset;       // Offset of the camera relative to the car
    public float smoothSpeed = 0.125f;  // Adjust for smoother camera movement

    void LateUpdate()
    {
        // Desired camera position
        Vector3 desiredPosition = car.position + offset;

        // Smoothly interpolate to the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Set the camera's position
        transform.position = smoothedPosition;

        // Make the camera look at the car
        transform.LookAt(car);
    }
}
