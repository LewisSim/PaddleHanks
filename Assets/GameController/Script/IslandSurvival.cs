using System.Collections;
using PaddleHanks.Island.Script;

namespace PaddleHanks.GameController.Script
{
    public class IslandSurvival : GameState
    {
        public IslandSurvival(StateMachine stateMachine) : base(stateMachine)
        {
        }

        public override IEnumerator Start()
        {
            IslandUI.ClearUI();
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
            if (GameValues.Instance.Day % 7 == 0)
            {
                yield return ChangeState(new Paddle(StateMachine));
            }
            else
            {
                yield return ChangeState(new IslandSurvival(StateMachine));
            }
        }
    }
}