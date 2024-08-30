using UnityEngine;

public class CameraEdgeMovement : MonoBehaviour
{
    public float edgeWidth = 10f; // The width border at the edge in which the movement works (in pixels)
    public float movementSpeed = 3f; // The speed of the camera movement (scale)

    private Vector3 rightDirection = Vector3.right; // The direction the camera should move when on the right edge

    void Update()
    {
        // Check if the mouse is on the right edge of the screen
        if (Input.mousePosition.x >= Screen.width - edgeWidth)
        {
            // Move the camera to the right
            transform.position += rightDirection * Time.deltaTime * movementSpeed;
        }
    }
}
