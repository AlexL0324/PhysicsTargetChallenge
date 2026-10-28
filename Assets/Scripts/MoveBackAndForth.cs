using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    public float speed = 2.0f;      // Speed of the movement
    public float distance = 3.0f;   // How far left and right it goes

    private float startX;

    void Start()
    {
        // Record the starting X position
        startX = transform.position.x;
    }

    void Update()
    {
        // Calculate new X position using a sine wave
        float newX = startX + Mathf.Sin(Time.time * speed) * distance;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
