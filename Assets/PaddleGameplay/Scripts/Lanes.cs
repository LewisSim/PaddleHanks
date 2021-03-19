namespace PaddleHanks.PaddleGameplay.Scripts
{
    public class Lanes
    {
        private readonly SwitchLanes _switchLanes;
        public Lane CurrentLane { get; private set; }
        private int _laneNumber;

        private int LaneNumber
        {
            get => _laneNumber;
            set
            {
                _laneNumber = value;
                switch (LaneNumber)
                {
                    case -1:
                        CurrentLane = Lane.Left;
                        _switchLanes.ChangeToLeftPosition();
                        break;
                    case 0:
                        CurrentLane = Lane.Middle;
                        _switchLanes.ChangeToMiddlePosition();
                        break;
                    case 1:
                        CurrentLane = Lane.Right;
                        _switchLanes.ChangeToRightPosition();
                        break;
                    default:
                        CurrentLane = CurrentLane;
                        break;
                }
            }
        }
        
        public enum Lane
        {
            Left,
            Middle,
            Right
        }

        public Lanes(SwitchLanes switchLanes)
        {
            _switchLanes = switchLanes;
        }
        
        public void Move(bool isMovingLeft)
        {
            if (isMovingLeft)
            {
                LaneNumber--;
            }
            else
            {
                LaneNumber++;
            }
            
        }
        
    }
}