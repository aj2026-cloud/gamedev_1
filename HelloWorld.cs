using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    float timer = 0f;
    int count = 0;

    void Start()
    {
        Debug.Log("My first Game!");
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            timer = 0f;
            count++;
            Debug.Log("Count: " + count);
        }
    }
}