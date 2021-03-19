using System;
using System.Collections.Generic;
using UnityEngine;

namespace PaddleHanks.IslandEvents.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 17/03/2021
    /// abstract for all island events, which holds the text to show
    /// </summary>
    [CreateAssetMenu(fileName = "IslandEvents", menuName = "ScriptableObjects/IslandEvents/IslandEvent")]
    public class IslandsEvents : ScriptableObject
    {
        public WeightedIslandEvent islandEvent = new WeightedIslandEvent();
    }
}