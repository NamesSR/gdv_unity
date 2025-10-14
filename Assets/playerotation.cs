using UnityEngine;

public class playerotation : MonoBehaviour
{
    public Transform playerPostion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPostion.rotation = transform.rotation;    

}
}
