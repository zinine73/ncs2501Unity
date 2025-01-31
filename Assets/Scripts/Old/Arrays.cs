using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public GameObject[] players;
    public GameObject enemy;
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        for (int i = 0; i < players.Length; i++)
        {
            Debug.Log($"Player Number {i} is named {players[i].name}");
        }
        //enemy = GameObject.FindGameObjectWithTag("Enemy");
        enemy = GameObject.FindWithTag("Enemy");
        Debug.Log($"Enemy is {enemy.name}");
    }
}
