using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRule : MonoBehaviour
{
   [SerializeField] private ScoreCounter score;
   [SerializeField] private ScoreCounter bid;


   private float GetBidScore()
   {
      return bid.Score > score.Score ?  score.Score : bid.Score;
   }
   public void AddScore()
   {
      if(bid.Score > score.Score)score.Add(score.Score);
      else score.Add(GetBidScore());
   }
   
   public void TakeAwayScore()
   {
      score.TakeAway(GetBidScore());
   }

}
