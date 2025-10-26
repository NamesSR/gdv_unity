using UnityEngine;

public class mov : MonoBehaviour
    // Start is called once before the first execution of Update after the MonoBehaviour is create
    {
        public float rotateSpeed = 90.0f; // graden per seconde

        void Update()
        {
            // Draai rond de Y-as
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }
    }