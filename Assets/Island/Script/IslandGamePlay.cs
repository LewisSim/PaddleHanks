using System.Collections;
using PaddleHanks.GameController.Script;
using UnityEngine;

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
            SetUI();
        }

        IEnumerator SetUI()
        {
            _ui.ChangeAllAttributeText(
                GameValues.Instance.attributes.Comfort.Attribute,
                GameValues.Instance.attributes.Health.Attribute,
                GameValues.Instance.attributes.Hunger.Attribute,
                GameValues.Instance.attributes.Thirst.Attribute);
            foreach (var dayEvent in GameValues.Instance.currentIslandDay.IslandEvents())
            {
                _ui.ChangeEventText(dayEvent.islandEvent.islandEvent.textToShow);
                _ui.SpawnChoices(dayEvent.islandEvent.islandEvent.choices);
                yield return new WaitUntil(() => _ui.IsChoicePicked);
                
            }
            
        }

        IEnumerator WaitForChoice()
        {
            yield break;
        }
    }
}