
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEditor;
    using UnityEditor.SceneManagement;
    using UnityEngine.SceneManagement;
    using System.Linq;
    using System.IO;

#if UNITY_EDITOR

    public class SceneSelector : EditorWindow
{
        private const string _scenesFolderPath = "Assets/Scenes/";
        private const string _assetPath = "Assets/Resources/";
        private const string _openedSceneFileName = "Utilities/OpenedScenes.txt";
        private Vector2 _scrollPos = Vector2.zero;
        private bool _isAutoPlayModeEnabled = true;

        [MenuItem("Tools/SceneSelector")]
        private static void OpenWindnow()
        {
            SceneSelector window = GetWindow<SceneSelector>();
            window.Show();
        }


        protected void OnGUI()
        {
            #region Event Link
            //EditorApplication.playModeStateChanged -= SaveLoadOpenedScenes;
            //EditorApplication.playModeStateChanged += SaveLoadOpenedScenes;
            #endregion Event Link

            #region Load Data
            string searchPattern = "*.unity";
            string[] filePaths = Directory.GetFiles(_scenesFolderPath, searchPattern);
            EditorBuildSettingsScene[] scenes = null;
            scenes = EditorBuildSettings.scenes;
            List<string> scenePaths = scenes.Select(scene => scene.path).ToList();
            #endregion Load Data

            #region Display
            _scrollPos = GUILayout.BeginScrollView(_scrollPos);
        #region Play Mode
        GUILayout.Label("SCENE SELECTOR", EditorStyles.boldLabel);
        //SirenixEditorGUI.Title("SCENE SELECTOR", "", TextAlignment.Center, true);
        EditorGUILayout.Space();

            if (EditorApplication.isPlaying == false)
            {
                if (GUILayout.Button("Play", GUILayout.Height(50)))
                {
                    EditorApplication.isPlaying = true;
                }
            }
            else
            {
                if (GUILayout.Button("Stop", GUILayout.Height(50)))
                {
                    EditorApplication.isPlaying = false;
                }
            }

            _isAutoPlayModeEnabled = EditorGUILayout.Toggle("Auto Play Mode Enabled", _isAutoPlayModeEnabled);

            if (_isAutoPlayModeEnabled)
            {
                EditorApplication.playModeStateChanged -= SaveLoadOpenedScenes;
                EditorApplication.playModeStateChanged += SaveLoadOpenedScenes;   
            }
            else
            {
                EditorApplication.playModeStateChanged -= SaveLoadOpenedScenes;
            }

            EditorGUILayout.Space();
            #endregion Play Mode

            #region Scenes In Build Settings
            EditorGUILayoutUtility.HorizontalLine();
            EditorGUILayout.Space();

            GUILayout.Label("SCENES IN BUILD SETTINGS", EditorStyles.boldLabel);
        //SirenixEditorGUI.Title("SCENES IN BUILD SETTINGS", "", TextAlignment.Center, true);

        for (int i = 0; i < scenes.Length; i++)
            {
                EditorGUILayout.BeginHorizontal();
                Scene scene = EditorSceneManager.GetSceneByPath(scenePaths[i]);
                if (!scene.isLoaded)
                {
                    if (!scene.IsValid())
                        GUI.backgroundColor = Color.grey;
                    else
                        GUI.backgroundColor = Color.black;
                    if (GUILayout.Button(Path.GetFileNameWithoutExtension(scenePaths[i]), GUILayout.Height(40), GUILayout.Width(250)))
                    {
                        EditorSceneManager.OpenScene(scenePaths[i], OpenSceneMode.AdditiveWithoutLoading);
                    }
                    GUI.backgroundColor = Color.grey;
                    if (GUILayout.Button("Load", GUILayout.Height(40)))
                    {
                        EditorSceneManager.OpenScene(scenePaths[i], OpenSceneMode.Additive);
                    }
                }
                else
                {
                    GUI.backgroundColor = Color.black;
                    if (GUILayout.Button(Path.GetFileNameWithoutExtension(scenePaths[i]), GUILayout.Height(40), GUILayout.Width(250)))
                    {
                    }
                    GUI.backgroundColor = Color.green;
                    if (GUILayout.Button("Unload", GUILayout.Height(40)))
                    {
                        EditorSceneManager.CloseScene(scene, false);
                    }
                }

                //Display close scene load button
                if (scene.IsValid())
                {
                    GUI.backgroundColor = Color.red;
                    if (GUILayout.Button("X", GUILayout.Height(40), GUILayout.Width(40)))
                    {
                        EditorSceneManager.CloseScene(scene, true);
                    }
                }
                EditorGUILayout.EndHorizontal();
            }
            #endregion Scenes In Build Settings

            #region Scenes Not Build Settings
            EditorGUILayoutUtility.HorizontalLine();
            EditorGUILayout.Space();

        GUILayout.Label("SCENES NOT BUILD SETTINGS", EditorStyles.boldLabel);
        //SirenixEditorGUI.Title("SCENES NOT BUILD SETTINGS", "", TextAlignment.Center, true);

        for (int i = 0; i < filePaths.Length; i++)
            {
                if (scenePaths.Contains(filePaths[i]) == false)
                {
                    EditorGUILayout.BeginHorizontal();
                    Scene scene = EditorSceneManager.GetSceneByPath(filePaths[i]);
                    if (!scene.isLoaded)
                    {
                        if (!scene.IsValid())
                            GUI.backgroundColor = Color.grey;
                        else
                            GUI.backgroundColor = Color.black;
                        if (GUILayout.Button(Path.GetFileNameWithoutExtension(filePaths[i]), GUILayout.Height(40), GUILayout.Width(250)))
                        {
                            EditorSceneManager.OpenScene(filePaths[i], OpenSceneMode.AdditiveWithoutLoading);
                        }
                        GUI.backgroundColor = Color.grey;
                        if (GUILayout.Button("Load", GUILayout.Height(40)))
                        {
                            EditorSceneManager.OpenScene(filePaths[i], OpenSceneMode.Additive);
                        }
                    }
                    else
                    {
                        GUI.backgroundColor = Color.black;
                        if (GUILayout.Button(Path.GetFileNameWithoutExtension(filePaths[i]), GUILayout.Height(40), GUILayout.Width(250)))
                        {
                        }
                        GUI.backgroundColor = Color.green;
                        if (GUILayout.Button("Unload", GUILayout.Height(40)))
                        {
                            EditorSceneManager.CloseScene(scene, false);
                        }
                    }

                    //Display close scene load button
                    if (scene.IsValid())
                    {
                        GUI.backgroundColor = Color.red;
                        if (GUILayout.Button("X", GUILayout.Height(40), GUILayout.Width(40)))
                        {
                            EditorSceneManager.CloseScene(scene, true);
                        }
                    }
                    EditorGUILayout.EndHorizontal();
                }
            }
            #endregion Scenes Not Build Settings
            GUILayout.EndScrollView();
            #endregion Display
        }

        private void SaveLoadOpenedScenes(PlayModeStateChange state)
        {
            if (state == PlayModeStateChange.EnteredEditMode)
            {
                StreamReader stream = new StreamReader(_assetPath + _openedSceneFileName);
                bool isFirstElement = true;
                while (!stream.EndOfStream)
                {
                    string line = stream.ReadLine();
                    if (isFirstElement)
                    {
                        EditorSceneManager.OpenScene(line, OpenSceneMode.Single);
                        isFirstElement = false;
                    }
                    else
                    {
                        EditorSceneManager.OpenScene(line, OpenSceneMode.Additive);
                    }
                }
                stream.Close();
            }
            else if (state == PlayModeStateChange.ExitingEditMode)
            {
                StreamWriter stream = new StreamWriter(_assetPath + _openedSceneFileName);
                SceneSetup[] sceneSetups = EditorSceneManager.GetSceneManagerSetup();
                for (int i = 0; i < sceneSetups.Length; i++)
                {
                    if (sceneSetups[i].isLoaded == true)
                    {
                        stream.WriteLine(sceneSetups[i].path);
                        Scene sceneToSave = EditorSceneManager.GetSceneByPath(sceneSetups[i].path);
                        EditorSceneManager.SaveScene(sceneToSave);
                    }
                }
                stream.Close();

                EditorBuildSettingsScene[] scenes = null;
                scenes = EditorBuildSettings.scenes;
                List<string> scenePaths = scenes.Select(scene => scene.path).ToList();

                EditorSceneManager.OpenScene(scenePaths[0], OpenSceneMode.Single);
            }
        }
    }
#endif
