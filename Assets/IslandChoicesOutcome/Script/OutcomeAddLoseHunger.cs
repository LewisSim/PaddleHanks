using PaddleHanks.GameController.Script;
using UnityEngine;

namespace PaddleHanks.IslandChoicesOutcome.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 19/03/2021
    /// Island Outcome that will add or lose hunger
    /// </summary>
    [CreateAssetMenu(fileName = "IslandOutcomeAddItem", menuName = "ScriptableObjects/IslandOutcomes/IslandOutcomeAddLoseHunger")]
    public class OutcomeAddLoseHunger : Outcome
    {
        [SerializeField] private float howMuchHunger;
        public override void DoOutcome()
        {
            GameValues.Instance.attributes.Hunger.Attribute =+ howMuchHunger;
        }
    }
}