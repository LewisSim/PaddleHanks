using System.Collections.Generic;
using PaddleHanks.IslandEvents.Script;
using PaddleHanks.WeightedRandom.Script;
using UnityEngine;

namespace PaddleHanks.IslandDays.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 19/03/2021
    /// return a List of random events
    /// </summary>
    [CreateAssetMenu(fileName = "IslandDay", menuName = "ScriptableObjects/IslandDay/IslandRandomDay")]
    public class IslandRandomDay : IslandsDays
    {
        [SerializeField] private int amountOfEvents;
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Randomised list of the weighted IslandEvents</returns>
        public override List<IslandsEvents> IslandEvents()
        {
            //Create a new instance of the randomisation through weighting
            var randomWeighting = new RandomWeighting<WeightedIslandEvent>();
            var weightedIslandsEvents = new List<WeightedIslandEvent>();
            //convert the current list into a weighting list
            foreach (var islandEvent in islandsEvents)
            {
                weightedIslandsEvents.Add(islandEvent.islandEvent);
            }
            var weightingOfEvents = new Weighting<WeightedIslandEvent>(weightedIslandsEvents);
            
            //get a randomised event, remove it from the weighting list, add it to a final list until we have completed it for amountOfEvents times
            var islandsEventsList = new List<IslandsEvents>();
            for (var i = amountOfEvents; i > 0; i--)
            {
                WeightedIslandEvent randomObject = randomWeighting.GetRandomObject(weightingOfEvents);
                var finalIslandEvent = CreateInstance<IslandsEvents>();
                finalIslandEvent.islandEvent = randomObject;
                islandsEventsList.Add(finalIslandEvent);
            }

            return islandsEventsList;
        }
    }
}