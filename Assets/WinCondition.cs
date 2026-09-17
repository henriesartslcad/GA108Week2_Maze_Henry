using System;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    private Transform player;
    private Transform goal;
    private float winDistance = 1.5f;
    private bool hasWon = false;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("welcome to forest");
        

    }

    // Update is called once per frame
    void Update()
    {

        goal = GameObject.Find("Goal").transform;
        player = GameObject.Find("Player").transform;

        if (hasWon) return;

        float distance = Vector3.Distance(player.position, goal.position);

        if (distance <= winDistance)
        {
            hasWon = true;
            WinGame();
        }

    }

     void WinGame()
    {
        Debug.Log("You Win!");
    }
}
