using System;
using UnityEngine;

namespace Convai.Scripts.Utils
{
    /// <summary>
    ///     This script defines global actions and settings for Convai.
    /// </summary>
    [AddComponentMenu("Convai/Convai Interactables Data")]
    [HelpURL("https://docs.convai.com/api-docs/plugins-and-integrations/unity-plugin/scripts-overview")]
    public class ConvaiInteractablesData : MonoBehaviour
    {
        [Tooltip("Array of Characters in the environment")]
        [SerializeField] public Character[] Characters;

        [Tooltip("Array of Objects in the environment")]
        [SerializeField] public Object[] Objects;

        public Transform DynamicMoveTargetIndicator;

        /// <summary>
        ///     Represents a character in the environment.
        /// </summary>
        [Serializable]
        public class Character
        {
            [SerializeField] public string Name;
            [SerializeField] public string Bio;
            [SerializeField] public GameObject gameObject;
        }

        [Serializable]
        public class Object
        {
            [SerializeField] public string Name;
            [SerializeField] public string Description;
            [SerializeField] public GameObject gameObject;
        }
    }
}