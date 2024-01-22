using System.Collections;
using MyGameDevTools.SceneLoading;
using UnityEngine;


[AddComponentMenu("Scene Loading/Loading Fader")]
[RequireComponent(typeof(CanvasGroup))]
public class LoadingFaderNacho : MonoBehaviour
{
    public LoadingBehavior loadingBehavior;
    [Range(.00f, 5)]
    public static float fadeTime = 0;

    [SerializeField]
    AnimationCurve _fadeOutCurve = AnimationCurve.EaseInOut(0, 1, 1, 0);
    [SerializeField]
    AnimationCurve _fadeInCurve = AnimationCurve.EaseInOut(0, 0, 1, 1);

    LoadingProgress _loadingProgress;
    CanvasGroup _canvasGroup;

    void Awake()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        _canvasGroup.alpha = 0;
    }

    void Start()
    {
        _loadingProgress = loadingBehavior.Progress;
        _loadingProgress.StateChanged += OnLoadingStateChanged;
        FadeIn();
    }

    void OnLoadingStateChanged(LoadingState loadingState)
    {
        if (loadingState == LoadingState.TargetSceneLoaded)
            FadeOut();
    }

    void FadeOut()
    {
        StartCoroutine(fadeOutRoutine());
        IEnumerator fadeOutRoutine()
        {
            yield return FadeRoutine(_fadeOutCurve);
            _loadingProgress.SetState(LoadingState.TransitionComplete);
        }
    }

    void FadeIn()
    {
        StartCoroutine(fadeInRoutine());
        IEnumerator fadeInRoutine()
        {
            yield return FadeRoutine(_fadeInCurve);
            _loadingProgress.SetState(LoadingState.Loading);
        }
    }

    IEnumerator FadeRoutine(AnimationCurve fadeCurve)
    {
        var time = 0f;
        while (time < fadeTime)
        {
            time += Time.deltaTime;
            _canvasGroup.alpha = fadeCurve.Evaluate(time / fadeTime);
            yield return null;
        }
    }
}
