using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class walking : MonoBehaviour

{
    
    public float moveSpeed = 5f;
    void Start()
    {
        
    }
     void Update()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");     // W/S toetsen


        

        Vector3 beweging = new Vector3(horizontalInput, 0f, vertical);
        transform.Translate(beweging * moveSpeed * Time.deltaTime);
        

      } 
} 