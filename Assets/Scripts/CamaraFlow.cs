using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;      // The player
    public Vector3 offset = new Vector3(0, 5, -7);  // Adjust as needed
    public float smoothSpeed = 5f;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothed = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothed;

        transform.LookAt(target); // Optional: makes camera always face player
    }
}
