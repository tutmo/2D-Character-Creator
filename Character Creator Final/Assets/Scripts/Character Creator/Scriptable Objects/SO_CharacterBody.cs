// Code written by tutmo (youtube.com/tutmo)
// For help, check out the tutorial - https://youtu.be/PNWK5o9l54w

using UnityEngine;

[CreateAssetMenu(fileName = "New Character Body", menuName = "Character Body")]
public class SO_CharacterBody : ScriptableObject
{
    // ~~ 1. Holds details about the full character body

    public BodyPart[] characterBodyParts;
}

[System.Serializable]
public class BodyPart
{
    public string bodyPartName;
    public SO_BodyPart bodyPart;
}
