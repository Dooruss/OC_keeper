using TMPro;
using UnityEngine;

public class STORY_Details : MonoBehaviour
{
    public TMP_Text storyText;
    public void SetOCDetails(STORY story)
    {
        storyText.text = story.StoryItself;
    }
}
