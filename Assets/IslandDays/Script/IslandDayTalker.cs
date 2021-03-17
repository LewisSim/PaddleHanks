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
        [SerializeField] private IslandDay _islandDay;

        private void Awake()
        {
            print(_islandDay.daysEvents[0].EventToOccur);
        }
    }
}