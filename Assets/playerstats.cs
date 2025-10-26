using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //Tip: Met een header kun je titels plaatsen in de inspector
    [Header("Character Info")]
    public string playerName = "DragonSlayer";
    public int level = 1;
    public string characterClass = "Warrior";
    public float movementspeed = 15f;
    public string race = "demi-human";
    

    [Header("Combat Stats")]
    public int health = 100;
    public int maxHealth = 100;
    public int mana = 50;
    public int attack = 25;
    public int defense = 15;
    public double critrate = 1;
    public int critdamage = 25;
    

    [Header("Game Progress")]
    public int experience = 0;
    public int gold = 150;
    public float playtimeHours = 2.5f;
    public bool hasCompletedTutorial = true;
    public bool boss1killed = false;   
    public bool boss2killed = false;    
    

    [Header("Inventory")]
    public int healthPotions = 3;
    public int keys = 1;
    public string currentWeapon = "Iron Sword";
    public int manapotions = 2;
    public int stenghtpotion = 1;
    

    void Start()
    {
        DisplayCharacterSheet();
    }

    void Update()
    {
        // Input om stats te updaten
        if (Input.GetKeyDown(KeyCode.L))
        {
            //Level UP!
            level++;
            maxHealth += 20;
            health = maxHealth; // Full heal bij level up
            attack += 5;
            defense += 3;
            mana += 10;
            critdamage += 4;
            critrate += 0.2;

            Debug.Log("LEVEL UP! Now level " + level);
            Debug.Log("Stats increased!");
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            //Use Health Potion
            if (healthPotions > 0 && health < maxHealth)
            {
                healthPotions--;
                health += 30;
                if (health > maxHealth) health = maxHealth;

                Debug.Log("Used health potion! Health: " + health + "/" + maxHealth);
                Debug.Log("Potions remaining: " + healthPotions);
            }
            else if (healthPotions <= 0)
            {
                Debug.Log("No health potions left!");
            }
            else
            {
                Debug.Log("Health is already full!");
            }
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            DisplayCharacterSheet();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            playerName = "noob";
            characterClass = "";
            race = "";
            level = 1;
            movementspeed = 0f;
            health = 0;
            maxHealth = 0;
            mana = 0;
            attack = 0;
            defense = 0;
            critrate = 0;
            critdamage = 0;
            experience = 0;
            gold = 0;
            playtimeHours = 0f;
            hasCompletedTutorial = false;
            boss1killed = false;
            boss2killed = false;
            healthPotions = 0;
            keys = 0;
            currentWeapon = "";
            manapotions = 0;
            stenghtpotion = 0;
          
            Debug.Log("Name: " + playerName + " the " + characterClass + " the " + race);
            Debug.Log("Level: " + level);
            Debug.Log("Health: " + health + "/" + maxHealth);
            Debug.Log("Mana: " + mana);
            Debug.Log("Attack: " + attack + " | Defense: " + defense);
            Debug.Log("crit rate " + critrate + " | crit damage " + critdamage);
            Debug.Log("movementspeed " + movementspeed);
            Debug.Log("Experience: " + experience + " XP");
            Debug.Log("Gold: " + gold + " coins");
            Debug.Log("Playtime: " + playtimeHours + " hours");
            Debug.Log("boss 1 killed " + boss1killed + " | boss 2 killed " + boss2killed);
            Debug.Log("Current Weapon: " + currentWeapon);
            Debug.Log("Items: " + healthPotions + " health potions, " + manapotions + " manapotions, " + stenghtpotion + " strenghtpotion, " + keys + " keys");
            Debug.Log("Tutorial Complete: " + hasCompletedTutorial);
            
        }

    }

    private void DisplayCharacterSheet()
    {
        //Display Character Sheet
    
        Debug.Log("=== CHARACTER SHEET ===");
        Debug.Log("Name: " + playerName + " the " + characterClass + " the " + race);
        Debug.Log("Level: " + level);
        Debug.Log("Health: " + health + "/" + maxHealth);
        Debug.Log("Mana: " + mana);
        Debug.Log("Attack: " + attack + " | Defense: " + defense);
        Debug.Log("crit rate " + critrate + " | crit damage " + critdamage);
        Debug.Log("movementspeed " + movementspeed);
        Debug.Log("Experience: " + experience + " XP");
        Debug.Log("Gold: " + gold + " coins");
        Debug.Log("Playtime: " + playtimeHours + " hours");
        Debug.Log("boss 1 killed " + boss1killed + " | boss 2 killed " + boss2killed);
        Debug.Log("Current Weapon: " + currentWeapon);
        Debug.Log("Items: " + healthPotions + " health potions, " + manapotions + " manapotions, " + stenghtpotion + " strenghtpotion, " + keys + " keys");
        Debug.Log("Tutorial Complete: " + hasCompletedTutorial);
        Debug.Log("========================");
    }
}