using System;
using UnityEngine;

namespace PaddleHanks.PaddleGameplay.Scripts
{
    /// <summary>
    /// Lewis Simmonds
    /// 19/03/2021
    /// Collision Controller
    /// </summary>
    [RequireComponent(typeof(CharacterController))]
    public class OnCollision : MonoBehaviour
    {
        [SerializeField]private string hitAbleObjectTag;
        private CharacterController _characterController;

        private void Awake() => _characterController = GetComponent<CharacterController>();

        private void OnTriggerEnter(Collider other)
        {
            if (!other.gameObject.CompareTag(hitAbleObjectTag))
                return;

            if (other.TryGetComponent(out IPlayerHitObject hitObject))
            {
                hitObject.HitObject(_characterController);
            }
            
        }

    }
}
