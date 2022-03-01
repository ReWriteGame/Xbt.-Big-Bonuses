using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
   public UnityEvent OpenEvent;

   private void Start()
   {
      OpenEvent?.Invoke();
   }
}
