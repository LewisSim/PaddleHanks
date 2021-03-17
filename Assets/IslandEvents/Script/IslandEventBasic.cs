using UnityEngine;

namespace PaddleHanks.IslandEvents.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 17/03/2021
    /// Scriptable Object that holds text for the event
    /// </summary>
    [CreateAssetMenu(fileName = "IslandEventBasic", menuName = "ScriptableObjects/IslandEvents/IslandEventBasic")]
    public class IslandEventBasic : IslandsEvents
    {
        [SerializeField] private IslandEvent islandEvent = new IslandEvent();
        private void OnEnable()
        {
            EventToOccur = islandEvent.textToShow;
        }
    }
}