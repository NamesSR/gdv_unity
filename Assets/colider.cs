using UnityEngine;

public class colider : MonoBehaviour
{
    public int pointValue = 10;
    public string itemName = "Coin";
    public int totaalpoints = 0;

    void Start()
    {
        // Zorg dat dit object een trigger is
        // Dit kun je ook via de inspector doen
        GetComponent<Collider>().isTrigger = true;
    }

    void OnTriggerEnter(Collider other)
    {
        // Alleen de player kan items oppakken
        if (other.gameObject.CompareTag("Player"))
        {
            // Gebruik functie om punten toe te voegen (Les 3.2!)
            AddPointsToPlayer(pointValue);

            // Gebruik functie om pickup effect te tonen
            ShowPickupEffect();

            // Vernietig het pickup item
            Destroy(gameObject);
        }
    }

    // Functie om punten toe te voegen (Les 3.2 kennis!)
    void AddPointsToPlayer(int points)
    {
        Debug.Log("Player picked up: " + itemName);
        Debug.Log("Points gained: " + points);
        totaalpoints = totaalpoints + points;
        Debug.Log("totaal points: " + totaalpoints);


        // Hier zou je later het scorebord kunnen bijwerken

    }

    // Functie om visueel effect te tonen
    void ShowPickupEffect()
    {
        Debug.Log("Pickup effect!");
        // Hier zou je later een particle effect kunnen spelen
    }
}