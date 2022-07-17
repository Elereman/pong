using UnityEngine.EventSystems;
using UnityEngine;

public class ScoringZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            BaseEventData baseEventData = new BaseEventData(EventSystem.current);
            scoreTrigger.Invoke(baseEventData);
        }
    }
}
