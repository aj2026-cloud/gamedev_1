using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, 6f) - 3f;
        transform.position = new Vector3(x, transform.position.y, transform.position.z);
    }
}