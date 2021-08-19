using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityGameObjectEvent : UnityEvent<object> { }

public class EventListener : MonoBehaviour
{
    public Event gEvent;
    public UnityGameObjectEvent response = new UnityGameObjectEvent();

    private void OnEnable()
    {
        gEvent.Register(this);
    }

    private void OnDisable()
    {
        gEvent.Unregister(this);
    }

    public void OnEventOccurs(object obj)
    {
        response.Invoke(obj);
    }
}