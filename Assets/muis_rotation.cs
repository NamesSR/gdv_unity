using UnityEngine;

public class muis_rotation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float mouseSensitivity = 100f;
    public Transform playerbody;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        playerbody.Rotate(Vector3.up * mouseX);
    }
}