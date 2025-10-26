using UnityEngine;

public class healthstatus : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int health = 100;
    public int maxHealt = 100;
    void Start()

    {

    }

    // Update is called once per frame
    void Update()
    {
        
            if (health > 80)
        {
            Debug.Log("Excellent health!");
        }
        else if (health > 50)
        {
            Debug.Log("Good health!");
        }
        else if (health > 20)
        {
            Debug.Log("Warning: Low health!");
        }
        else
        {
            Debug.Log("Critical: Very low health!");
        }
        if (Input.GetKeyDown(KeyCode.H) && health > 0)


        {
            Debug.Log("you have taken damage");
            health = health - 10;

        }

        if (Input.GetKeyDown(KeyCode.J) && health < maxHealt)
        {
            Debug.Log("you are healing your self");
            health = health + 10;

        }
        if (health == 0)
        {
            Debug.Log("game over");

        }
        
    }
}
