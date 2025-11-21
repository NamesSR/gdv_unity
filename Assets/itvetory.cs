using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class itvetory : MonoBehaviour
{
    
    public List<GameObject> items;
    public int i = 0;
    void Start()
    {
        i -= 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(i);
        if (items.Count > 0 && Input.GetKeyDown(KeyCode.R))
        {
            
            items[i].SetActive(true);
           
            items.RemoveAt(i );
            
            i--;
            Debug.Log("r");
        }
    }
}
