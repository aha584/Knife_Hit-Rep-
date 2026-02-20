using UnityEngine;
using System.Collections.Generic;
using AYellowpaper.SerializedCollections;

[CreateAssetMenu(fileName = "BlockInven", menuName = "BlockInven")]
public class BlockInven : ScriptableObject
{
    public List<Sprite> knives = new();
    public List<Sprite> knivesShadow = new();

    [SerializedDictionary("Knife Sprite", "Unlocked?")]
    public SerializedDictionary<Sprite, bool> knivesAndTheirState = new();

}
