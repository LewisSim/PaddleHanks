using System.Collections.Generic;
using PaddleHanks.IslandEvents.Script;
using UnityEngine;

namespace PaddleHanks.IslandDays.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 19/03/2021
    /// hold a list of islandsEvents
    /// </summary>
    public abstract class IslandsDays : ScriptableObject
    {
        [SerializeField] protected List<IslandsEvents> islandsEvents = new List<IslandsEvents>();
        public abstract List<IslandsEvents> IslandEvents();
    }
}