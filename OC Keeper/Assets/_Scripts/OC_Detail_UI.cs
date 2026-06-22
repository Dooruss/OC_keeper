using UnityEngine;
using TMPro;

public class OC_Detail_UI : MonoBehaviour
{
    public TMP_Text Text_OC_Name;
    public TMP_Text Text_OC_Pronouns;
    public TMP_Text Text_OC_Age;
    public TMP_Text Text_OC_Birthday;
    public TMP_Text Text_OC_Height;
    public TMP_Text Text_OC_Sexuality;


    public void SetOCDetails(OC oc)
    {
        Text_OC_Name.text = oc.Name;
        Text_OC_Age.text = "Age: " + oc.Age.ToString();
        Text_OC_Pronouns.text = oc.Pronouns;
        Text_OC_Birthday.text = "Birthday: " + oc.Birthday.ToString();
        Text_OC_Height.text = "Height: " + oc.Height.ToString() + "cm";
        Text_OC_Sexuality.text = "Sexuality: " + oc.Sexuality.ToString();
    }
}
