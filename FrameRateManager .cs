using UnityEngine;

public class FrameRateManager : MonoBehaviour
{
    public int targetFrameRate = 60;

    private void Awake()
    {
        Application.targetFrameRate = targetFrameRate;
    }
}
