using PaddleHanks.GameController.Script;
using UnityEngine;

namespace PaddleHanks.PaddleGameplay.Scripts
{
    /// <summary>
    /// Lewis Simmonds
    /// 19/03/2021
    /// Movement Controller
    /// </summary>
    [RequireComponent(typeof(CharacterController))]
    public class Movement : MonoBehaviour
    {
        private float moveSpeed => GameValues.Instance.paddleMovementSpeed;

        private CharacterController _characterController;

        private void Awake() => _characterController = GetComponent<CharacterController>();

        private void FixedUpdate()
        {
            var vertical = Input.GetAxis("Vertical");
            
            //if we are not going forward lets not go anywhere
            if(vertical <= 0)
                return;
            
            //apply movement on the z axis
            var direction = new Vector3(0, 0, vertical);
            var movement = transform.TransformDirection(direction) * moveSpeed;
            _characterController.SimpleMove(movement);
            
        }
    }
}
