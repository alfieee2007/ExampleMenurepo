using System.Runtime.InteropServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int health = 100;
    private int maxhealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Current Health is " + health);
        Applydamage(10);
        Debug.Log("Current Health is " + health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool Applydamage(int damage)
    {
        if(health - damage < 0)
        {
            //die
            return true;

        }
        else
        {
            health = health - damage;
            return false;
        }
           
    
    }
}
