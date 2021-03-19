using System;
using UnityEngine;

namespace PaddleHanks.PaddleGameplay.Scripts
{
    public class SwitchLanes : MonoBehaviour
    {
        [SerializeField] private Transform leftLaneObject;
        [SerializeField] private Transform middleLaneObject;
        [SerializeField] private Transform rightLaneObject;
        private Lanes _lanes;
        private CharacterController _characterController;

        private void Awake()
        {
            _lanes = new Lanes(this);
            _characterController = GetComponent<CharacterController>();
        }

        private void Update()
        {
            print(_lanes.CurrentLane);
            if (Input.GetKeyDown(KeyCode.A)|| Input.GetKeyDown(KeyCode.LeftArrow))
            {
                MoveLeft();
            }
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                MoveRight();
            }
        }

        private void MoveLeft()
        {
            if (_lanes.CurrentLane == Lanes.Lane.Left)
                return;
            _characterController.enabled = false;
            _lanes.Move(true);
            _characterController.enabled = true;
        }

        private void MoveRight()
        {
            if (_lanes.CurrentLane == Lanes.Lane.Right)
                return;
            _characterController.enabled = false;
            _lanes.Move(false);
            _characterController.enabled = true;
        }

        protected internal void ChangeToLeftPosition() => gameObject.transform.position = leftLaneObject.position;
        protected internal void ChangeToMiddlePosition() => gameObject.transform.position = middleLaneObject.position;
        protected internal void ChangeToRightPosition() => gameObject.transform.position = rightLaneObject.position;
    }
}
