using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class STORY_Details : MonoBehaviour
{
    public TMP_Text StoryTitle;
    public TMP_Text storyText;
    [Header("Charachter Mentions")]
    public Transform CharachterParent;
    public GameObject CharachterButtonPrefab;
    public OC_Detail_UI oC_Detail_UI;
    public GameObject[] Story_UI;

    public void SetStoryDetails(STORY story)
    {
        StoryTitle.text = story.StoryName;
        SetCharachtersMentioned(story);
        storyText.text = story.StoryItself;
    }

    private void SetCharachtersMentioned(STORY story)
    {
        // Remove old buttons
        foreach (Transform child in CharachterParent) Destroy(child.gameObject);

        // Create a button for each charachter
        foreach (OC charachter in story.Characters_Mentioned)
        {
            GameObject obj = Instantiate(CharachterButtonPrefab, CharachterParent);

            CharacterMentionButton ui = obj.GetComponent<CharacterMentionButton>();
            Button button = obj.GetComponent<Button>();
            ui.NameText.text = charachter.Name;

            button.onClick.AddListener(() =>
            {
                oC_Detail_UI.gameObject.SetActive(true);
                for (int i = 0; i < Story_UI.Length; i++)
                {
                    Story_UI[i].SetActive(false);
                }
                oC_Detail_UI.SetOCDetails(charachter);
            });
        }
    }
}
