using System.Collections.Generic;
using UnityEngine;

public static class GraphicsSettingsManager
{
    private static Resolution[] resolutions;

    public static List<string> ResolutionOptionsStrings { get; private set; }

    public static void OnAwake()
    {
        resolutions = Screen.resolutions;

        List<string> options = new();

        for (int i = 0; i < resolutions.Length; i++)
        {
            options.Add(resolutions[i].width + " x " + resolutions[i].height);

            if (resolutions[i].width == Screen.currentResolution.width
                && resolutions[i].height == Screen.currentResolution.height)
            {
                GameSettingsManager.SetResolutionIndex(i);
            }
        }

        ResolutionOptionsStrings = options;
    }

    public static void OnStart()
    {
        SetGraphics(GameSettingsManager.GraphicsIndex);
        SetResolution(GameSettingsManager.ResolutionIndex);
    }

    public static void SetGraphics(int index)
    {
        QualitySettings.SetQualityLevel(index);
        GameSettingsManager.SetGraphicsIndex(index);
    }

    public static void SetResolution(int index)
    {
        Screen.SetResolution(resolutions[index].width, resolutions[index].height, Screen.fullScreen);
        GameSettingsManager.SetResolutionIndex(index);
    }
}