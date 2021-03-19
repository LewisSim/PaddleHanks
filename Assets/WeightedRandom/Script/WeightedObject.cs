using System;
using UnityEngine;

namespace PaddleHanks.WeightedRandom.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 17/03/2021
    /// Class for all weighted objects, inherit from this on your class to add to the weighting system
    /// </summary>
    [Serializable]
    public class WeightedObject
    {
        [Tooltip("How likely the item will appear.")]
        [SerializeField] public float weight;
        [NonSerialized] public float cumulative;
    }
}
