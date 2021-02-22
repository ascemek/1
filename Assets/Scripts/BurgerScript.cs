using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Adds 20 points and display the winning screen when the player finds the burger
public class BurgerScript : MonoBehaviour
{

    public GameBehavior GameManager;
    private bool showWinScreen = false;

    void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("You found the BURGER!");
    
            GameManager.Items += 20;
            showWinScreen = true;
        }
    }

}
