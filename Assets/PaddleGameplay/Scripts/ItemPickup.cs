using PaddleHanks.GameController.Script;
using PaddleHanks.Items.Script;
using UnityEngine;

namespace PaddleHanks.PaddleGameplay.Scripts
{
    /// <summary>
    /// Lewis Simmonds
    /// 19/03/2021
    /// Add the item to the inventory
    /// </summary>
    public class ItemPickup : MonoBehaviour, IPlayerHitObject
    {
        [SerializeField] private Item itemToPickup;
        private MeshRenderer _mesh;

        private void Awake() => _mesh = GetComponent<MeshRenderer>();
        public void HitObject(CharacterController characterController)
        {
            GameValues.Instance.itemsPlayHas.Add(itemToPickup);
            _mesh.enabled = false;
        }
    }
}