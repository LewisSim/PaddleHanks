using System.Collections;
using PaddleHanks.PaddleGameplay.Scripts;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PaddleHanks.GameController.Script
{
    public class Paddle : GameState
    {
        private PaddlingGameplay _paddlingGameplay;
        public Paddle(StateMachine stateMachine) : base(stateMachine)
        {
        }

        public override IEnumerator Start()
        {
            SceneManager.LoadScene(0);
            _paddlingGameplay = new PaddlingGameplay();
            yield return Play();
        }

        public override IEnumerator Play()
        {
            yield return _paddlingGameplay.StartTimer();
            yield return new WaitUntil(() => _paddlingGameplay.GamePlayFinished);
            yield return End();
        }

        public override IEnumerator End()
        {
            SceneManager.LoadScene(1);
            StateMachine.BeginIslandArea();
            yield break;
        }
    }
}