using UnityEngine;

namespace PaddleHanks.IslandChoicesOutcome.Script
{

    /// <summary>
    /// Lewis Simmonds
    /// 19/03/2021
    /// Island Outcomes that will allow the player to have any of the outcomes
    /// </summary>
    public abstract class Outcome : ScriptableObject
    {
        public string textOfOutcome;
        public abstract void DoOutcome();
    }
}
