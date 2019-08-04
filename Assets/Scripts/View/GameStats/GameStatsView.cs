using System;
using Presenter.GameStats;
using UnityEngine;
using UnityEngine.UI;

namespace View.GameStats
{
    public class GameStatsView : View
    {
        [SerializeField] private Text score, world, level, bestLevelTimes;

        public void SetStats(Model.GameStats gameStats)
        {
            score.text = $"Score: {gameStats.Score}";
            world.text = $"World: {gameStats.World}";
            level.text = $"Level: {gameStats.Level}";
            bestLevelTimes.text = string.Empty;

            var levelCount = 0;
            foreach (var levelTime in gameStats.BestLevelTimes)
            {
                levelCount++;
                bestLevelTimes.text += $"Level {levelCount} - " +
                                       $"{new TimeSpan(0, 0, 0, (int) levelTime):g}\r\n";
            }
        }

        public void ShowApartmentBase()
        {
            if( Presenter is GameStatsPresenter statsPresenter)
                statsPresenter.SetNewApartmentBalcony();
        }
    }
}