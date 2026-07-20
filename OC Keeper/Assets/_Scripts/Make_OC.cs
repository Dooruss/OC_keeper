using System.Xml.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Make_OC : MonoBehaviour
{
    [SerializeField] private TMP_InputField Input_Name;
    [SerializeField] private TMP_InputField Input_Pronouns;

    public void Create_OC()
    {
        CheckEmpties();
        ScriptableObject OC = ScriptableObject.CreateInstance(typeof(OC));
        (OC as OC).Name = Input_Name.text;
        (OC as OC).Pronouns = Input_Pronouns.text;
    }

    private void CheckEmpties()
    {
        if (string.IsNullOrEmpty(Input_Name.text))
        {
            Debug.LogError("Name cannot be empty.");
            return;
        }
        if (string.IsNullOrEmpty(Input_Pronouns.text))
        {
            Debug.LogError("Pronouns cannot be empty.");
            return;
        }
    }
}
