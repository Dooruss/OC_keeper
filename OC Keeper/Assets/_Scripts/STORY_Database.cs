using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
public class STORY_Database : MonoBehaviour
{
    public Transform contentParent;
    public GameObject StoryButtonPrefab;
    public List<STORY> AllStories = new List<STORY>();
    public STORY_Details detailsUI;

    public void OpenStoryDatabase()
    {
        // CLEAR OLD BUTTONS
        foreach (Transform child in contentParent)
        {
            Destroy(child.gameObject);
        }


        foreach (STORY story in AllStories)
        {
            GameObject buttonObj = Instantiate(StoryButtonPrefab, contentParent);
            TMP_Text text = buttonObj.GetComponentInChildren<TMP_Text>();
            Button button = buttonObj.GetComponent<Button>();
            text.text = story.StoryName;

            button.onClick.AddListener(() =>
            {
                detailsUI.gameObject.SetActive(true);
                detailsUI.SetStoryDetails(story);
            });

        }
    }
}
