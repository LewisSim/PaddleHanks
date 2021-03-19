using System.Collections;
using System.Collections.Generic;
using PaddleHanks.GameController.Script;
using UnityEngine;

namespace PaddleHanks.PaddleGameplay.Scripts
{
    public class PaddlingGameplay
    {
        public bool GamePlayFinished;

        public PaddlingGameplay()
        {
            float day = GameValues.Instance.Day;
            if (day == 0)
                return;
            
            GameValues.Instance.paddleMovementSpeed *= day / 10f;
        }

        public IEnumerator StartTimer()
        {
            var timer = 0f;
            while (timer < 30f)
            {
                timer += Time.deltaTime;
            }

            GamePlayFinished = true;
            yield break;
        }

    }
}
