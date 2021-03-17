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
        [SerializeField] private Text _eventText;
        
        [Header("Text components for attributes.")]
        [SerializeField] private Text _comfortText, _healthText, _hungerText, _thirstText;

        #region Event Text Changer
        public void ChangeEventText(string textToChangeTo) => _eventText.text = textToChangeTo;
        
        #endregion
        
        #region Attribute Text Changers
        public void ChangeComfortText(string textToChangeTo) => _comfortText.text = textToChangeTo;
        
        public void ChangeHealthText(string textToChangeTo) => _healthText.text = textToChangeTo;
        
        public void ChangeHungerText(string textToChangeTo) => _hungerText.text = textToChangeTo;
        
        public void ChangeThirstText(string textToChangeTo) =>_thirstText.text = textToChangeTo;
        
        public void ChangeAllAttributeText(string comfortText, string healthText, string hungerText, string thirstText)
        {
            ChangeComfortText(comfortText);
            ChangeHealthText(healthText);
            ChangeHungerText(hungerText);
            ChangeThirstText(thirstText);
        }
        #endregion

        public void ClearUI()
        {
            ChangeAllAttributeText(string.Empty, string.Empty, string.Empty, string.Empty);
            
        }
        
    }
}