using UnityEngine;
using UnityEngine.InputSystem;

public class SpinColor : MonoBehaviour
{
    public float spinSpeed = 90f;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rend.material.color = Random.ColorHSV();
        }
    }
}