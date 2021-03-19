using System;
using PaddleHanks.GameController.Script;
using UnityEngine;

namespace PaddleHanks.PaddleGameplay.Scripts
{
    /// <summary>
    /// Lewis Simmonds
    /// 19/03/2021
    /// Add the item to the inventory
    /// </summary>
    public class ItemHealOrDamagePlayer : MonoBehaviour, IPlayerHitObject
    {
        private MeshRenderer _mesh;
        private void Awake() => _mesh = GetComponent<MeshRenderer>();

        [SerializeField] private float amountToHealOrDamage;
        public void HitObject(CharacterController characterController)
        {
            GameValues.Instance.attributes.Health.Attribute =+ amountToHealOrDamage;
            characterController.velocity.Set(0f,0f,0f);
            _mesh.enabled = false;

        }
    }
}