using System.Collections;
using PaddleHanks.Island.Script;

namespace PaddleHanks.GameController.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 16/03/2021
    /// Abstract class for each GameState.
    /// </summary>
    public abstract class GameState
    {
        protected readonly StateMachine StateMachine;
        protected IslandUI IslandUI => StateMachine.islandUI;

        protected GameState(StateMachine stateMachine)
        {
            StateMachine = stateMachine;
        }

        /// <summary>
        /// Change state to the given state.
        /// </summary>
        /// <param name="gameState">State to change to.</param>
        /// <returns></returns>
        protected IEnumerator ChangeState(GameState gameState)
        {
            StateMachine.SetState(gameState);
            yield break;
        }

        #region Behaviours
        public virtual IEnumerator Start()
        {
            yield break;
        }

        public virtual IEnumerator Play()
        {
            yield break;
        }

        public virtual IEnumerator End()
        {
            yield break;
        }

        #endregion
    }


}