using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class OC_Info_Databse : MonoBehaviour
{
    public Transform contentParent;
    public GameObject OCButtonPrefab;
    public List<OC> AllOCs = new List<OC>();
    public OC_Detail_UI detailsUI;

    public void OpenOCSDatabase()
    {
        // CLEAR OLD BUTTONS
        foreach (Transform child in contentParent)
        {
            Destroy(child.gameObject);
        }


        foreach (OC oc in AllOCs)
        {
            GameObject buttonObj = Instantiate(OCButtonPrefab, contentParent);
            TMP_Text text = buttonObj.GetComponentInChildren<TMP_Text>();
            Button button = buttonObj.GetComponent<Button>();
            text.text = oc.name;

            button.onClick.AddListener(() =>
            {
                detailsUI.gameObject.SetActive(true);
                detailsUI.SetOCDetails(oc);
            });

        }
    }

}
