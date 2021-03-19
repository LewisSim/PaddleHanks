using System;
using UnityEngine;

namespace PaddleHanks.IslandDays.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 17/03/2021
    /// Scriptable Object that holds text for the event
    /// </summary>
    public class IslandDayTalker : MonoBehaviour
    {
        [SerializeField] private IslandsDays _islandDay;

        private void Awake()
        {
            var islandsEvents = _islandDay.IslandEvents();
            Debug.Log(islandsEvents[0].islandEvent.islandEvent.textToShow);
        }
    }
}