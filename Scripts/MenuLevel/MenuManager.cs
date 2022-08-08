using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] Transform kafa;
    [SerializeField] Transform startBtn;

    void Start()
    {
        kafa.transform.GetComponent<RectTransform>().DOLocalMoveX(0f, 1f).SetEase(Ease.OutBack);
        startBtn.transform.GetComponent<RectTransform>().DOLocalMoveY(-270f, 1f).SetEase(Ease.OutBack);
    }

    void Update()
    {
        
    }

    public void OyunaBasla()
    {
        SceneManager.LoadScene("GameLevel");
    }
}
