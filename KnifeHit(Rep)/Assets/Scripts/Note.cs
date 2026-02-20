using UnityEngine;
using System.Collections.Generic;
using AYellowpaper.SerializedCollections;

public class Note : MonoBehaviour
{
    [TextArea(5, 300)]
    public string description;

    //public Dictionary<Sprite, bool> knivesAndThierState = new();
/*
    [SerializedDictionary("Knife Sprite", "Unlocked?")]
    public SerializedDictionary<Sprite, bool> knivesAndTheirState = new();

    private void Start()
    {
        foreach (var kv in knivesAndTheirState)
        {

        }
    }*/
}