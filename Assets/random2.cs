using Unity.Collections;
using UnityEngine;

public class random2 : MonoBehaviour
{
    [SerializeField] string[] item;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return)) PrintRandomItem();
        if (Input.GetKeyDown(KeyCode.Escape)) PrintAllItems();
    }
    private void PrintRandomItem()
    {
        int random = Random.Range(0, 9);
        Debug.Log(item[random]);
    }
    private void PrintAllItems()
    {
        for (int i = 0; i < item.Length; i++)
        {
            Debug.Log(item[i]);
        }
    }

}