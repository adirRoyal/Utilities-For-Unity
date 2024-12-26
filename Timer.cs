using System;
using UnityEngine;

public class Timer
{
    private float duration;
    private float timeElapsed;
    private bool isRunning;

    public Action OnComplete;

    public Timer(float duration, Action onComplete)
    {
        this.duration = duration;
        this.OnComplete = onComplete;
    }

    public void Start()
    {
        isRunning = true;
        timeElapsed = 0f;
    }

    public void Stop()
    {
        isRunning = false;
    }

    public void Update(float deltaTime)
    {
        if (!isRunning) return;

        timeElapsed += deltaTime;
        if (timeElapsed >= duration)
        {
            isRunning = false;
            OnComplete?.Invoke();
        }
    }
}
