using UnityEngine;

[CreateAssetMenu(fileName = "STORY", menuName = "Scriptable Objects/STORY")]
public class STORY : ScriptableObject
{
    public string StoryName;
    public OC[] Characters_Mentioned;
    [TextArea(1, 20)]
    public string StoryItself;
}
