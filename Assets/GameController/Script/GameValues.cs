using System.Collections.Generic;
using PaddleHanks.Attributes.Script;
using PaddleHanks.IslandDays.Script;
using UnityEngine;

namespace PaddleHanks.GameController.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 16/03/2021
    /// Singleton that controls all game values
    /// </summary>
    public class GameValues : MonoBehaviour
    {
        public static GameValues Instance;
        private int _day;

        public int Day
        {
            get => _day;
            set
            {
                _day = value;
                currentIslandDay = days[_day + 1];
            }
        }

        public PlayerAttributesController attributes;
        public List<IslandsDays> days = new List<IslandsDays>();
        public IslandsDays currentIslandDay;
        
        private void Awake()
        {
            Day = 1;
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }
}