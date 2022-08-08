using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GeriSayimManager : MonoBehaviour
{
    [SerializeField] GameObject geriSayimObj;
    [SerializeField] Text geriSayimTxt;

    GameManager gameManager;
    private void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
    }
    void Start()
    {
        StartCoroutine(GeriyeSayRoutine());
    }

    IEnumerator GeriyeSayRoutine()
    {
        geriSayimTxt.text = "3";
        yield return new WaitForSeconds(0.5f);
        geriSayimObj.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1f);
        geriSayimObj.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.6f);

        geriSayimTxt.text = "2";
        yield return new WaitForSeconds(0.5f);
        geriSayimObj.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1f);
        geriSayimObj.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.6f);

        geriSayimTxt.text = "1";
        yield return new WaitForSeconds(0.5f);
        geriSayimObj.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1f);
        geriSayimObj.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.6f);

        StopAllCoroutines();

        gameManager.OyunaBasla();
    }
}
