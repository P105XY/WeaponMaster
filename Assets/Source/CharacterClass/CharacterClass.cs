using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterClass : MonoBehaviour
{
    public Rigidbody2D characterRigidbody2D;
    public Animator characterAnimator;
    public Animation characterAnimation;
    public SpriteRenderer characterSpriteRenderer;

    public CharacterWeaponClass characterWeaponClass;

    [SerializeField]
    private CharacterDataNamespace.CharacterDataStruct characterDataStruct;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
