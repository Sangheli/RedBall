using System.Linq;
using UnityEditor;
using UnityEngine;

public class AndroidBuilder
{
    [MenuItem("Build/Build Android")]
    public static void Build()
    {
        Debug.Log($"Build Start");
        BuildPipeline.BuildPlayer(GetEnabledScenes(), $"{GetFolder()}\\{GetName()}", BuildTarget.Android, GetBuildOptions());
        Debug.Log($"Build Done");
    }

    private static string[] GetEnabledScenes()
    {
        return EditorBuildSettings.scenes
            .Where(scene => scene.enabled)
            .Select(scene => scene.path)
            .ToArray();
    }
    
    private static string GetName()
    {
        return "game.apk";
    }

    private static string GetFolder()
    {
        return "androidBuild";
    }

    private static BuildOptions GetBuildOptions()
    {
        return BuildOptions.None;
    }
}