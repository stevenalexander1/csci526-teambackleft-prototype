using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    [SerializeField, ReadOnly] private List<Item> _inventory;
    

    
    // Start is called before the first frame update
    void Start()
    {
        _inventory = new List<Item>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void AddItem(Item item)
    {
        _inventory.Add(item);
    }
    
    public void RemoveItem(Item item)
    {
        _inventory.Remove(item);
    }
}
