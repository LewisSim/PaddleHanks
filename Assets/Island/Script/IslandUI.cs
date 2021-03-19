using System;
using UnityEngine;
using UnityEngine.UI;

namespace PaddleHanks.Island.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 17/03/2021
    /// UI controller for the Island area
    /// </summary>
    public class IslandUI : MonoBehaviour
    {
        [Header("Text component for events")] 
        [SerializeField] private Text eventText;
        
        [Header("Text components for attributes.")]
        [SerializeField] private Text comfortText, healthText, hungerText, thirstText;

        [SerializeField] private Choices choices;
        [NonSerialized] public Choices ChoicePicked;

        #region Event Text Changer
        public void ChangeEventText(string textToChangeTo) => eventText.text = textToChangeTo;
        
        #endregion
        
        #region Attribute Text Changers
        public void ChangeComfortText(string textToChangeTo) => comfortText.text = textToChangeTo;
        
        public void ChangeHealthText(string textToChangeTo) => healthText.text = textToChangeTo;
        
        public void ChangeHungerText(string textToChangeTo) => hungerText.text = textToChangeTo;
        
        public void ChangeThirstText(string textToChangeTo) =>thirstText.text = textToChangeTo;
        
        public void ChangeAllAttributeText(string comfortsText, string healthsText, string hungersText, string thirstsText)
        {
            ChangeComfortText(comfortsText);
            ChangeHealthText(healthsText);
            ChangeHungerText(hungersText);
            ChangeThirstText(thirstsText);
        }
        #endregion

        public void ClearUI()
        {
            ChangeAllAttributeText(string.Empty, string.Empty, string.Empty, string.Empty);
            
        }
        
    }

    public class Choices : MonoBehaviour
    {
        public GameObject panel;
        [SerializeField] private Text choicesText;
        
        private IslandUI IslandUI;

        public void ChangeChoiceText(string choiceText)
        {
            choicesText.text = choiceText;
        }

        public void SelectChoice()
        {
            IslandUI.ChoicePicked = this;
        }
    }
}