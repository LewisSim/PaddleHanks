using System.Collections;
using PaddleHanks.Attributes.Script;
using PaddleHanks.Island.Script;

namespace PaddleHanks.GameController.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 16/03/2021
    /// 17/03/2021 continued making
    /// Class for each first Island State GameState.
    /// </summary>
    public class IslandSurvivalDayFirst : GameState
    {
        public IslandSurvivalDayFirst(StateMachine stateMachine) : base(stateMachine)
        {
        }

        //initialise the GameValues attributes
        public override IEnumerator Start()
        {
            GameValues.Instance.attributes = new PlayerAttributesController(0f, 10f, 8f, 8f);
            yield return Play();
        }

        public override IEnumerator Play()
        {
            var islandGamePlay = new IslandGamePlay(IslandUI);
            yield return End();
        }

        public override IEnumerator End()
        {
            GameValues.Instance.Day++;
            yield return ChangeState(new IslandSurvival(StateMachine));
        }

    }
}