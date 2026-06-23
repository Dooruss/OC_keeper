using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OC_Detail_UI : MonoBehaviour
{
    public TMP_Text Text_OC_Name;
    public TMP_Text Text_OC_Pronouns;
    public TMP_Text Text_OC_Age;
    public TMP_Text Text_OC_Birthday;
    public TMP_Text Text_OC_Height;
    public TMP_Text Text_OC_Sexuality;
    // ------------------------------
    [Header("Important Info")]
    public TMP_Text Text_Ethnicity;
    public TMP_Text Text_Species;
    public TMP_Text Text_CountryResidance;
    // ------------------------------
    [Header("General info")]
    public TMP_Text Text_Occupation;
    public TMP_Text Text_hobbys;
    public TMP_Text Text_Religious;
    public TMP_Text Text_Signature_Weapon;
    public TMP_Text Text_Weaknesses;
    public TMP_Text Text_Fear_Phobia;
    public TMP_Text Text_Fav_Food;
    public TMP_Text Text_Fav_Color;
    // ------------------------------
    [Header("Skills")]
    public TMP_Text Text_Able_To_Cook;
    public TMP_Text Text_Able_To_Bake;
    public TMP_Text Text_Able_To_Drive;
    public TMP_Text Text_Able_To_Instruments;
    // ------------------------------
    [Header("Backstory")]
    public TMP_Text Text_Backstory;
    // ------------------------------
    [Header("Appearance")]
    public TMP_Text Text_Body;
    public TMP_Text Text_Eyes;
    public TMP_Text Text_Hair;
    public TMP_Text Text_Clothing;
    public TMP_Text Text_Fantasy_Features;
    public TMP_Text Text_Defining_Features;
    public TMP_Text Text_Voice;

    public void SetOCDetails(OC oc)
    {
        Text_OC_Name.text = oc.Name;
        Text_OC_Age.text = "Age: " + oc.Age.ToString();
        Text_OC_Pronouns.text = oc.Pronouns;
        Text_OC_Birthday.text = "Birthday: " + oc.Birthday.ToString();
        Text_OC_Height.text = "Height: " + oc.Height.ToString() + "cm";
        Text_OC_Sexuality.text = "Sexuality: " + oc.Sexuality.ToString();
        Text_Ethnicity.text = "Ethnicity: " + oc.Ethnicity;
        Text_Species.text = "Species: " + oc.Species;
        Text_CountryResidance.text = "Country of Residence: " + oc.Residance_Country;
        Text_Occupation.text = "Occupation: " + oc.Occupation;
        Text_hobbys.text = "Hobbies: " + oc.hobbys;
        Text_Religious.text = "Religious: " + (oc.Religious ? "Yes" : "No");
        Text_Signature_Weapon.text = "Signature Weapon: " + oc.Signature_Weapon;
        Text_Weaknesses.text = "Weaknesses: " + oc.Weaknesses;
        Text_Fear_Phobia.text = "Fear/Phobia: " + oc.Fear_Phobia;
        //Skills
        Text_Able_To_Bake.text = "Able to Bake: " + (oc.Able_To_Bake ? "Yes" : "No");
        Text_Able_To_Cook.text = "Able to Cook: " + (oc.Able_To_Cook ? "Yes" : "No");
        Text_Able_To_Drive.text = "Able to Drive: " + (oc.Able_To_Drive ? "Yes" : "No");
        Text_Able_To_Instruments.text = "Able to Play Instruments: " + oc.Able_To_Instruments;
        //Appearance
        Text_Body.text = "Body: " + oc.Body;
        Text_Eyes.text = "Eyes: " + oc.Eyes;
        Text_Hair.text = "Hair: " + oc.Hair;
        Text_Clothing.text = "Clothing: " + oc.Clothing;
        Text_Fantasy_Features.text = "Fantasy Features: " + oc.Fantasy_Features;
        Text_Defining_Features.text = "Defining Features: " + oc.Defining_Features;
        Text_Voice.text = "Voice: " + oc.Voice;
        //Backstory
        Text_Backstory.text = oc.Backstory;
    }
}
