using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
//this class should probably be abstract.
{
    private String unitName = "Placeholder";
    private Integer moveLength = 0;
    private abstract Enum unitType { One, Two, Three } //placeholder type names. this should probably be put somewhere else. abstracted 'cuz it shouldn't be implemented ever.
    private unitType thisUnitType = unitType.One
    private List<Item> inventory = new List<Item>(); //this declaration smells like a problem-causing line of code. should be moved.
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
