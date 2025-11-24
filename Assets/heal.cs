using UnityEngine;

public class heal : MonoBehaviour

{
    public string itemType = "HealthPotion";
    public int value = 10;

    void Start()
    {
        GetComponent<Collider>().isTrigger = true; // Les 4.1: trigger maken
    }


    void OnTriggerEnter(Collider other) // Les 4.2: collision detection
    {
        if (other.CompareTag("Player")) // Les 4.1: tag checking
        {
            //Haal het script van de player op!
            healthstatus player = other.GetComponent<healthstatus>();

            // Switch uit Les 5.1 + collision uit Les 4.2
            switch (itemType)
            {
             
                case "HealthPotion":
                    // Alleen oppakken als je schade hebt
                    if (player.health < 100)
                    {
                        player.health += value;
                        Debug.Log("Health restored!");
                        Destroy(gameObject);
                    }
                    else
                    {
                        Debug.Log("Health already full!");
                    }
                    break;

                
            }
        }
    }
}