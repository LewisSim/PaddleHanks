using PaddleHanks.Items.Script;
using UnityEngine;

namespace PaddleHanks.PaddleGameplay.Scripts
{
    /// <summary>
    /// Lewis Simmonds
    /// 19/03/2021
    /// Hit Object Interface
    /// </summary>
    internal interface IPlayerHitObject
    {
        void HitObject(CharacterController characterController);
    }
}