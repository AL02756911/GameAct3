using UnityEngine;

public class Orbit : MonoBehaviour
{

    [SerializeField] private Transform centerObject;  // Object to orbit around
    [SerializeField, Range(1f, 100f)] private float orbitSpeed = 20f;  // Orbit speed
    [SerializeField] private bool clockwise = true;   // Direction of the orbit
    [SerializeField, Range(1f, 100f)] private float selfRotationSpeed = 20f; // Self-rotation speed
    [SerializeField] private bool selfClockwise = true; // Direction of self-rotation

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        
    }

    void FixedUpdate(){
        // Check if a parent object is assigned to rotate around
        if (centerObject != null) {
            // Determine rotation direction: if clockwise, use -1; otherwise, use 1
            float direction = clockwise ? -1f : 1f;

            // Rotate around centerObject
            transform.RotateAround(centerObject.position, Vector3.forward, direction * orbitSpeed * Time.deltaTime);
        }

        // Determine rotation direction for self: if clockwise, use -1; otherwise, use 1
        float selfDirection = selfClockwise ? -1f : 1f;
        // Self-rotation
        transform.Rotate(Vector3.forward * selfDirection * selfRotationSpeed * Time.deltaTime);

    }
}
