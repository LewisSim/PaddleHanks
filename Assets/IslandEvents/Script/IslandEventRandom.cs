using System;
using System.Collections.Generic;
using PaddleHanks.WeightedRandom.Script;
using UnityEngine;

namespace PaddleHanks.IslandEvents.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 17/03/2021
    /// Scriptable Object that will randomise what text to output
    /// </summary>
    [CreateAssetMenu(fileName = "IslandEventRandom", menuName = "ScriptableObjects/IslandEvents/IslandEventRandom")]
    public class IslandEventRandom : IslandsEvents
    {
        [SerializeField] private List<WeightedIslandEvent> weightedIslandEvents = new List<WeightedIslandEvent>();

        private void OnEnable()
        {
            var weightedIslandEvent = new Weighting<WeightedIslandEvent>(weightedIslandEvents);
            var randomWeighting = new RandomWeighting<WeightedIslandEvent>();
            var randomObject = randomWeighting.GetRandomObject(weightedIslandEvent);
            EventToOccur = randomObject.islandEvent.textToShow;
        }
    }
}