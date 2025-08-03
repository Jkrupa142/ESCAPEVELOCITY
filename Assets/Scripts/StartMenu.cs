using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void StartButton()
    {
        DOTween.Clear(this);
        SceneManager.LoadScene("OutdoorsScene");
    }
}
