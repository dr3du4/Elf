using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    public Statistic stats;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int GetDamage(int health)
    {
        health = health - stats.attack;
        return health;
    }

    int drop()
    {
        return Random.Range(1,6);
    }
}
