using System;
using System.Collections.Generic;
using PaddleHanks.IslandEventsChoices.Script;

namespace PaddleHanks.IslandEvents.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 17/03/2021
    /// Island Event that will allow the designer to say whatever they want each event
    /// </summary>
    [Serializable]
    public class IslandEvent
    {
        public string textToShow;
        public List<Choices> choices = new List<Choices>();
    }
}