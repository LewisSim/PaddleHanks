using PaddleHanks.GameController.Script;
using UnityEngine;

namespace PaddleHanks.IslandChoicesOutcome.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 19/03/2021
    /// Island Outcome that will add or minus health
    /// </summary>
    [CreateAssetMenu(fileName = "IslandOutcomeAddItem", menuName = "ScriptableObjects/IslandOutcomes/IslandOutcomeAddLoseHealth")]
    public class OutcomeAddLoseHealth : Outcome
    {
        [SerializeField] private float howMuchHealth;
        public override void DoOutcome()
        {
            GameValues.Instance.attributes.Health.Attribute =+ howMuchHealth;
        }
    }
}