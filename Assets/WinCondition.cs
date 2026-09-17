
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
        //OKAY IM NOT GOING TO LIE IM NOT ENTIRELY SURE WHY THIS WORKS . but i figured i'd need to get the location
        // of the objects and associate them with 'player' and 'goal' so i typed into google 'how to get location of 
        // an object c# unity' and found a unity discussions forum post that had a script reference for find game object
        // and the example was like . hand = GameObject.Find("Hand"); and then the .transform after it fetches the position
        // it worked but i thought i was supposed to be doing something with vector3? maybe? but this works? haha

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
