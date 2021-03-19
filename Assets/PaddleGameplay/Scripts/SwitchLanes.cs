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

        private void Awake() => _lanes = new Lanes(this);

        private void FixedUpdate()
        {
            var horizontal = Input.GetAxis("Horizontal");
            if (horizontal == 0)
                return;

            if (horizontal > 0)
            {
                MoveLeft();
            }

            if (horizontal < 0)
            {
                MoveRight();
            }
        }

        private void MoveLeft()
        {
            if (_lanes.CurrentLane == Lanes.Lane.Left)
                return;
            _lanes.Move(true);
        }

        private void MoveRight()
        {
            if (_lanes.CurrentLane == Lanes.Lane.Middle)
                return;
            _lanes.Move(false);
        }

        protected internal void ChangeToLeftPosition() => gameObject.transform.position = leftLaneObject.position;
        protected internal void ChangeToMiddlePosition() => gameObject.transform.position = middleLaneObject.position;
        protected internal void ChangeToRightPosition() => gameObject.transform.position = rightLaneObject.position;
    }
}
