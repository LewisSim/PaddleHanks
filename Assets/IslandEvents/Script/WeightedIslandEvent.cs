using System;
using PaddleHanks.WeightedRandom.Script;

namespace PaddleHanks.IslandEvents.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 17/03/2021
    /// IslandEvent that has been given the weighted properties
    /// </summary>
    [Serializable]
    public class WeightedIslandEvent : WeightedObject
    {
        public IslandEvent islandEvent = new IslandEvent();
    }

}