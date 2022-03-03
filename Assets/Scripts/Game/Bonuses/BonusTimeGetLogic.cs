using System;
using UnityEngine;
using UnityEngine.Events;

public class BonusTimeGetLogic : MonoBehaviour
{
    [SerializeField] private Bonuses bonuses;
    [SerializeField] private int timeGetBonuses = 30;
    
    public UnityEvent activateTimeEvent;
    public UnityEvent updateActivateTimeEvent;
 

 
    public void Activate()
    {
        activateTimeEvent?.Invoke();
        int allMinutes = DateTime.Now.Hour * 60 + DateTime.Now.Minute;
        bonuses.SetLastTime(allMinutes);
    }
 
    private void Update()
    {
        int allMinutes = DateTime.Now.Hour * 60 + DateTime.Now.Minute;
        if (Mathf.Abs(bonuses.LastReceivedTime - allMinutes ) >= timeGetBonuses)
        {
            updateActivateTimeEvent?.Invoke();
        }
    }
}
