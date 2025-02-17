using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadSceneAsync("Stage");
        SoundManager.Inst.PlaySound_UI(UIClips.Click);
    }
}
