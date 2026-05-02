using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public Transform cameraAnchor; // Drag the "CameraAnchor" CHILD of the car here
    public float smoothSpeed = 10f;
    public float rotationSpeed = 5f;

    void LateUpdate() 
    {
        if (cameraAnchor == null) return;

        // 1. Move to the anchor's position
        transform.position = Vector3.Lerp(transform.position, cameraAnchor.position, smoothSpeed * Time.deltaTime);

        // 2. Smoothly rotate to match the anchor's rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, cameraAnchor.rotation, rotationSpeed * Time.deltaTime);
    }
}
