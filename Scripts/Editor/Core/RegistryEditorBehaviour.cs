﻿using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace BrunoMikoski.ScriptableObjectCollections
{
    [InitializeOnLoad]
    public static class RegistryEditorBehaviour
    {
        static RegistryEditorBehaviour()
        {
            EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
        }

        private static void OnPlayModeStateChanged(PlayModeStateChange playModeStateChange)
        {
            if (playModeStateChange == PlayModeStateChange.EnteredPlayMode)
            {                
                CollectionsRegistry.Instance.ReloadCollections();
                CollectionsRegistry.Instance.RemoveNonAutomaticallyInitializedCollections();
            }
            else if (playModeStateChange == PlayModeStateChange.EnteredEditMode)
            {
                CollectionsRegistry.Instance.ReloadCollections();
            }
        }
    }
}
