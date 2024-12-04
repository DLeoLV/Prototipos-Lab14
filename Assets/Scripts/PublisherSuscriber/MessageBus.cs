using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageBus : MonoBehaviour
{
    public Dictionary<string, Action<string>> _subscribers = new Dictionary<string, Action<string>>();

    public void Subscribe(string messageType, Action<string> listener)
    {
        if (!_subscribers.ContainsKey(messageType))
        {
            _subscribers[messageType] = listener;
        }
        else
        {
            _subscribers[messageType] += listener;
        }
    }

    public void Unsubscribe(string messageType, Action<string> listener)
    {
        if (_subscribers.ContainsKey(messageType))
        {
            _subscribers[messageType] -= listener;
            if (_subscribers[messageType] == null)
                _subscribers.Remove(messageType);
        }
    }

    public void Publish(string messageType, string message)
    {
        if (_subscribers.ContainsKey(messageType))
        {
            _subscribers[messageType]?.Invoke(message);
        }
    }
}