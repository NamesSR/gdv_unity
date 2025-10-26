using UnityEngine;

public class weaponswitch : MonoBehaviour
{
        public string currentWeapon = "Sword";
        public int damage;
        public float attackSpeed;

        void Start()
        {
            SetWeaponStats();
        }

        void Update()
        {
           
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                EquipWeapon("Sword");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                EquipWeapon("Bow");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                EquipWeapon("Staff");
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                EquipWeapon("Dagger");
            }
        }

        void EquipWeapon(string weaponName)
        {
            
        currentWeapon = weaponName;
        Debug.Log("Equipped: " + currentWeapon);
        SetWeaponStats();
            
        }

        void SetWeaponStats()
        {
            switch (currentWeapon)
            {
                case "Sword":
                    damage = 25;
                    attackSpeed = 1.0f;
                    Debug.Log("Sword: Balanced weapon");
                    break;

                case "Bow":
                    damage = 20;
                    attackSpeed = 1.5f;
                    Debug.Log("Bow: Fast ranged weapon");
                    break;

                case "Staff":
                    damage = 35;
                    attackSpeed = 0.7f;
                    Debug.Log("Staff: Powerful but slow");
                    break;

                case "Dagger":
                    damage = 15;
                    attackSpeed = 2.0f;
                    Debug.Log("Dagger: Very fast, low damage");
                    break;

                default:
                    damage = 10;
                    attackSpeed = 1.0f;
                    Debug.Log("Unarmed: Weak but always available");
                    break;
            }

            Debug.Log("Damage: " + damage + ", Speed: " + attackSpeed);
        }
    }