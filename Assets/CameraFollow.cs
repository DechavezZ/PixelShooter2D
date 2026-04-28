using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void LateUpdate()
    {
        if (player != null)
        {
            Vector3 newPosition = new Vector3(
                player.position.x,
                offset.y,
                player.position.z + offset.z
            );

            transform.position = newPosition;
        }
    }
}