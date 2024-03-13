using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterWeaponDataNamespace
{
    [Serializable]
    struct CharacterWeaponDataStruct
    {
        public string weaponName;
        public int weaponDamage;
        public float weaponRange;
        public float weaponAttackSpeed;
        public float weaponAttackCooldown;
        public float weaponAttackCooldownTimer;

        public CharacterWeaponDataStruct(string weaponName, int weaponDamage, float weaponRange, float weaponAttackSpeed, float weaponAttackCooldown, float weaponAttackCooldownTimer)
        {
            this.weaponName = weaponName;
            this.weaponDamage = weaponDamage;
            this.weaponRange = weaponRange;
            this.weaponAttackSpeed = weaponAttackSpeed;
            this.weaponAttackCooldown = weaponAttackCooldown;
            this.weaponAttackCooldownTimer = weaponAttackCooldownTimer;
        }
    }
}