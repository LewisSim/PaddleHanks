using PaddleHanks.GameController.Script;
using PaddleHanks.Items.Script;
using UnityEngine;

namespace PaddleHanks.IslandChoicesOutcome.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 19/03/2021
    /// Island Outcome that will add an item
    /// </summary>
    public class OutcomeAddItem : Outcome
    {
        [SerializeField] private Item whatItemToGive;
        public override void DoOutcome()
        {
            GameValues.Instance.itemsPlayHas.Add(whatItemToGive);
        }
    }
}