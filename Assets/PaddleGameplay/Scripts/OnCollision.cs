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
        [SerializeField]private GameObject hitAbleObject;
        private CharacterController _characterController;

        private void Awake() => _characterController = GetComponent<CharacterController>();

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject != hitAbleObject)
                return;
            other.gameObject.GetComponent<IPlayerHitObject>().HitObject(_characterController);
        }

    }
}
