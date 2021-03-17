using System;
using System.Collections.Generic;
using UnityEngine;

namespace PaddleHanks.WeightedRandom.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 17/03/2021
    /// Class for all weighting holders, add this to your scriptable object to have a list of weighted objects
    /// </summary>
    public class Weighting<T> where T : WeightedObject
    {
        public List<T> objects;
        public float totalWeight;
        
        public Weighting(IEnumerable<T> _objects)
        {
            objects = new List<T>(_objects);
            GetTotalWeight();
        }
        
        
        /// <summary>
        /// Get the total weight of all objects
        /// </summary>
        private void GetTotalWeight()
        {
            var objectsTotal = 0f;
            foreach (var items in objects)
            {
                objectsTotal += items.weight;
                items.cumulative = objectsTotal;
            }
            totalWeight = objectsTotal;
        }
    }
}
