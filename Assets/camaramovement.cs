using UnityEngine;

public class camaramovement : MonoBehaviour
{
    public Transform CameraPosition;
    public Vector3 offSetcamera = new Vector3(5, 5, 5);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CameraPosition.position = transform.position + offSetcamera;
        CameraPosition.rotation = transform.rotation;
    }
}
