using UnityEngine;

public class RotateLetter : MonoBehaviour
{
    public new Transform transform;
    public float speed = 1;

    void Update()
    {
        transform.Rotate(speed, 0, 0);
    }
}
