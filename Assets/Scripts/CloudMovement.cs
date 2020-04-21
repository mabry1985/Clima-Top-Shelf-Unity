using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    private Vector3 normalizeDirection;

    public Transform target;
    public float speed = 1f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
