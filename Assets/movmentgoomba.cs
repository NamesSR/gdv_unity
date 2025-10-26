using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class movment : MonoBehaviour

{
    public Transform target;
    public float step = .5f;
    public Transform from;
    public Transform to;
    public float speed = 1f;
    public float timeCount = 0.0f;



    void Start()
    {
       
    }
    void Update()
    {
        
        
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Iets is de trigger binnen gekomen!");
        Debug.Log("rotation: " + other.gameObject.name);
        
        if (other.gameObject.name == "rotation")
        {
            transform.rotation = Quaternion.Lerp(from.rotation, to.rotation, timeCount * speed);
            timeCount = timeCount + Time.deltaTime;
        }

    } 
}
