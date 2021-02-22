using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Adds 10 points when the player finds the turtle
public class TurtleScript : MonoBehaviour
{
    public GameBehavior GameManager;

    void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("You found the turtle!");
            GameManager.Items += 10;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Find the burger now!");
        }
    }

}