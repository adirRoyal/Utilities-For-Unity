using System.IO;
using UnityEngine;

public static class JsonUtilityHelper
{
    public static void SaveToFile<T>(T data, string filePath)
    {
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(filePath, json);
    }

    public static T LoadFromFile<T>(string filePath) where T : new()
    {
        if (!File.Exists(filePath))
        {
            Debug.LogWarning($"File not found: {filePath}");
            return new T();
        }

        string json = File.ReadAllText(filePath);
        return JsonUtility.FromJson<T>(json);
    }
}
