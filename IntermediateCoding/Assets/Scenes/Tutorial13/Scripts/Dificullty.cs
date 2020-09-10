using UnityEngine;

namespace Scenes.Tutorial13.Scripts
{
    public static class Dificullty
    {
         static float secondsToMaxDifficulty=60;
         
         public static float GetDificultyPercnt()
         {
              
             return Mathf.Clamp01(Time.timeSinceLevelLoad / secondsToMaxDifficulty);
         }
        
    }
}