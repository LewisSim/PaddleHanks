using System.Collections.Generic;
using PaddleHanks.IslandEvents.Script;
using UnityEngine;

namespace PaddleHanks.IslandDays.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 17/03/2021
    /// return a list of every event attached
    /// </summary>
    [CreateAssetMenu(fileName = "IslandDay", menuName = "ScriptableObjects/IslandDay/IslandDay")]
    public class IslandDay : IslandsDays
    {
        public override List<IslandsEvents> IslandEvents()
        {
            return islandsEvents;
        }
    }
}