using UnityEngine;
using UnityEditor;
using System.IO;

public class CreateProjectFolders : MonoBehaviour
{
    [MenuItem("Tools/Create Project Folders")]
    public static void CreateFolders()
    {
        // Create the Assets directory if it doesn't exist
        if (!AssetDatabase.IsValidFolder("Assets"))
        {
            AssetDatabase.CreateFolder("", "Assets");
        }

        // Create subdirectories within the Assets folder
        string[] folders = new string[] { "Animations", "Audio", "Fonts", "Materials", "Models", "Plugins", "Prefabs", "Scenes", "Scripts", "Shaders", "Textures" };

        foreach (string folder in folders)
        {
            string path = "Assets/" + folder;
            if (!AssetDatabase.IsValidFolder(path))
            {
                AssetDatabase.CreateFolder("Assets", folder);
            }
        }

        // Refresh the AssetDatabase to show the new folders in the Unity Editor
        AssetDatabase.Refresh();
    }
}
