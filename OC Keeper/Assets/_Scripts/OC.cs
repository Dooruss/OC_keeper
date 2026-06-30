using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "OC", menuName = "Scriptable Objects/OC")]
public class OC : ScriptableObject
{
    // Main stuff
    [Header("Main Info")]
    public string Name;
    public string Pronouns;
    public int Age;
    public string Birthday;
    public float Height;
    public enum Chosen_Sexuality
    {
        straight , gay ,lesbian , bisexual , pansexual , Attracted_To_Nai
    }
    public Chosen_Sexuality Sexuality;
    public Sprite Main_Picture;
    // Relationships
    // later im lazy asf

    // Importaznt info
    [Header("Important Info")]
    public string Occupation;
    public enum Chosen_Ethnicity
    {
        America , german
    }
    public enum Chosen_Species
    {
        Human , Fairy , Zombie , Skeleton , Demon , Angel , God , Werewolf , Vampire , Ghost , Witch , Mermaid , Siren
    }
    public enum Chosen_Residance_Country
    {
        Opaline , Carolti , Berinvino , Zexom
    }
    public Chosen_Ethnicity Ethnicity;
    public Chosen_Species Species;
    public Chosen_Residance_Country Residance_Country;

    //Relationship
    [Header("Relationships")]
    public List<Relationship> Relationships = new List<Relationship>();
    // General info
    [Header("General info")]
    public string hobbys;
    public bool Religious;
    public string Signature_Weapon;
    public string Weaknesses;
    public string Fear_Phobia;
    public string Fav_Food;
    public string Fav_Color;
    // Skills
    [Header("Skills")]
    public bool Able_To_Cook;
    public bool Able_To_Bake;
    public bool Able_To_Drive;
    public string Able_To_Instruments;
    //backstory
    [Header("Backstory")]
    [TextArea(1, 5)]
    public string Backstory;
    //Appearance
    [Header("Appearance")]
    public string Body;
    public string Eyes;
    public string Hair;
    public string Clothing;
    public string Fantasy_Features;
    public string Defining_Features;
    public string Voice;
}

[System.Serializable]
public class Relationship
{
    ///  All possible relationship types for an OC. This enum is used to categorize the nature of the relationship between two OCs.
    public enum RelationshipType
    {
        Friend , BestFriend , Sibling , Parent , Romantic , Acquaintance , Enemy , Sweetheart , Crush , Mentor,
        Rival , Colleague , Classmate , Roommate , Neighbour , Married , Ex , Partner , Fiancé , Divorced , Protector , Child , 
        Grandparent , Grandchild , Cousin , Aunt , Uncle , In_Law , Step_Parent , Step_Sibling , Teacher , Boss , complicated
    }
    public RelationshipType Type;
    // With who?
    public OC Character;

    // An text area is actually just a string but if u want to write long parts like descriptions u can better use this because u can press enter for extra lines!
    [TextArea(3, 6)]
    public string Description;
}