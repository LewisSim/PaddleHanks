using PaddleHanks.GameController.Script;

namespace PaddleHanks.Island.Script
{
    public class IslandGamePlay
    {
        private IslandUI _ui;

        public IslandGamePlay(IslandUI ui)
        {
            _ui = ui;
            StartIsland();
        }

        private void StartIsland()
        {
            throw new System.NotImplementedException();
        }

        void SetUI()
        {
            foreach (var dayEvent in GameValues.Instance.currentIslandDay.IslandEvents())
            {
                _ui.ChangeEventText(dayEvent.islandEvent.islandEvent.textToShow);
            }
            
        }
    }
}