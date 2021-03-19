using System;
using System.Collections.Generic;
using PaddleHanks.GameController.Script;
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
        [SerializeField] private Slider comfort, health, hunger, thirst;

        [SerializeField] private GameObject choiceParent;
        [SerializeField] private GameObject choicesPrefab;
        [NonSerialized] public Choices ChoicePicked;
        [NonSerialized] public bool IsChoicePicked;
        

        private void Awake()
        {
            var stateMachine = FindObjectOfType<StateMachine>();
            stateMachine.islandUI = this;
        }
        
        #region Event Text Changer
        public void ChangeEventText(string textToChangeTo) => eventText.text = textToChangeTo;
        
        #endregion
        
        #region Attribute Text Changers
        public void ChangeComfortText(float valueToChangeTo) => comfort.value = valueToChangeTo / 10f;
        
        public void ChangeHealthText(float valueToChangeTo) => health.value = valueToChangeTo / 10f;
        
        public void ChangeHungerText(float valueToChangeTo) => hunger.value = valueToChangeTo / 10f;
        
        public void ChangeThirstText(float valueToChangeTo) => thirst.value = valueToChangeTo / 10f;
        
        public void ChangeAllAttributeText(float comforts, float healths, float hungers, float thirsts)
        {
            ChangeComfortText(comforts);
            ChangeHealthText(healths);
            ChangeHungerText(hungers);
            ChangeThirstText(thirsts);
        }
        #endregion

        public void ClearUI()
        {
            ChangeAllAttributeText(0, 0, 0, 0);
            
        }

        public void SpawnChoices(List<IslandEventsChoices.Script.Choices> choices)
        {
            foreach (var choice in choices)
            {
                var choiceObj = Instantiate(choicesPrefab, choiceParent.transform);
                var choiceObjChoices = choiceObj.GetComponent<Choices>();
                choiceObjChoices.islandUI = this;
                choiceObjChoices.choicesText.text = choice.choice;
            }
        }
        
    }

    public class Choices : MonoBehaviour
    {
        public Text choicesText;
        public IslandUI islandUI;
        

        public void ChangeChoiceText(string choiceText)
        {
            choicesText.text = choiceText;
        }

        public void SelectChoice()
        {
            islandUI.ChoicePicked = this;
        }
    }
}