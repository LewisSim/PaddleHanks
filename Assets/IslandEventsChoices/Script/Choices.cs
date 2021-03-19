using System.Collections.Generic;
using PaddleHanks.IslandChoicesOutcome.Script;
using UnityEngine;

namespace PaddleHanks.IslandEventsChoices.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 19/03/2021
    /// Island Choice that will allow the player to choose any of the events
    /// </summary>
    [CreateAssetMenu(fileName = "IslandChoices", menuName = "ScriptableObjects/IslandChoices/IslandChoices")]
    public class Choices : ScriptableObject
    {
        public string choice;
        public List<Outcome> outcomes = new List<Outcome>();
    }
}