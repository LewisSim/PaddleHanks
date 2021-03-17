using UnityEngine;

namespace PaddleHanks.IslandEvents.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 17/03/2021
    /// abstract for all island events, which holds the text to show
    /// </summary>
    public abstract class IslandsEvents : ScriptableObject
    {
        public string EventToOccur { get; set; }
        
    }
}