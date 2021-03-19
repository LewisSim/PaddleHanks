using PaddleHanks.GameController.Script;
using UnityEngine;

namespace PaddleHanks.IslandChoicesOutcome.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 19/03/2021
    /// Island Outcome that will add or lose thirst
    /// </summary>
    [CreateAssetMenu(fileName = "IslandOutcomeAddItem", menuName = "ScriptableObjects/IslandOutcomes/IslandOutcomeAddLoseThirst")]
    public class OutcomeAddLoseThirst : Outcome
    {
        [SerializeField] private float howMuchThirst;
        public override void DoOutcome()
        {
            GameValues.Instance.attributes.Thirst.Attribute =+ howMuchThirst;
        }
    }
}