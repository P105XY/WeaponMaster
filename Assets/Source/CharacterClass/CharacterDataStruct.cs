using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterDataNamespace
{
    [Serializable]
    public struct CharacterDataStruct
    {
        public string characterName;
        public int characterLevel;
        public int characterHealth;
        public int characterMana;
        public int characterStrength;
        public int characterAgility;
        public int characterAccuracy;
        public int characterTechnique;
    }
}
