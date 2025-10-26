using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class triggerit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
     
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player entered damage zone");
        StartCoroutine(WaitExample());
    }

    IEnumerator WaitExample()
    {
        for (int i = 0; i < 10; i++) 
        {
            Debug.Log("Player takes 10 damage");
            yield return new WaitForSeconds(1f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Player left damage zone");
    }
}