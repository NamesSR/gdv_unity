using UnityEngine;

public class upanddown : MonoBehaviour
{
    public float amplitude = 9.0f; // hoe hoog/laag de sins golf
    public float frequency = 1.0f; // hoe snell
    public float rotateSpeed = 90.0f;

    private Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newY = startPosition.y * amplitude * Mathf.Sin(Time.time * frequency);
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
        
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }

}