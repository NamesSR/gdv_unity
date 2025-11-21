using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem.Utilities;

public class inventoripickup : MonoBehaviour
{
    
    public Transform playerPosition;
    public Vector3 offSetplayer = new Vector3(0, 0, 0);
    public itvetory s1;
    public GameObject s2;
    
    int replase = 0;

    void Start()
    {
       
        gameObject.SetActive(true);
        s1.items.Clear();
    }

   
   
    
        
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player")) // Les 4.1: tag checking
            {
            additem();


            }
        }
    
    void additem()
    {
        s1.i++;
        replase++;
        s1.items.Add(gameObject);
        s2.SetActive(false);
    }
   
    void OnEnable()
    {
        if (replase > 0)
        {
            transform.position = playerPosition.position + offSetplayer;
        }
    }
}
