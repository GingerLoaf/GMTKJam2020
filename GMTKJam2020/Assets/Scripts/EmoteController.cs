using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class EmoteController : MonoBehaviour
{

    [SerializeField]
    private Image m_happyEmote = null;

    [SerializeField]
    private Image m_sadEmote = null;

    [SerializeField]
    private Image m_excitedEmote = null;

    [SerializeField]
    private Image m_bubble = null;

    [SerializeField]
    private AnimationCurve m_scaleCurve = null;

    private CancellationTokenSource m_tokenSource = null;

    private void OnEnable()
    {
        m_bubble.enabled = false;
        m_happyEmote.enabled = false;
        m_sadEmote.enabled = false;
        m_excitedEmote.enabled = false;

        InitializeTokenSource();
    }

    private void OnDisable()
    {
        ReleaseTokenSource();
    }

    private void ReleaseTokenSource()
    {
        m_tokenSource?.Cancel();
        m_tokenSource?.Dispose();
        m_tokenSource = null;
    }

    private void InitializeTokenSource()
    {
        m_tokenSource = new CancellationTokenSource();
    }

    private void ResetToken()
    {
        ReleaseTokenSource();
        InitializeTokenSource();
    }

    public void SetIndex(int index)
    {
        var emote = (BudEmote)index;

        ResetToken();

        if (index > 0)
        {
            ShowEmoteAsync(emote, m_tokenSource.Token);
        }
    }

    private void Update()
    {
        m_bubble.transform.localRotation = Quaternion.Euler(0f, 0f, Mathf.Sin(Time.time * 10f) * 30f);
    }

    private async void ShowEmoteAsync(BudEmote emote, CancellationToken cancellationToken)
    {
        m_bubble.enabled = true;
        m_happyEmote.enabled = emote == BudEmote.Happy;
        m_sadEmote.enabled = emote == BudEmote.Scared;
        m_excitedEmote.enabled = emote == BudEmote.Excited;

        var start = DateTime.UtcNow;
        while (true)
        {
            var elapsed = DateTime.UtcNow - start;
            var elapsedT = (float)elapsed.TotalSeconds / 0.25f;
            var elapsedF = m_scaleCurve.Evaluate(elapsedT);
            m_bubble.transform.localScale = Vector3.LerpUnclamped(Vector3.zero, Vector3.one, elapsedF);

            if (elapsedT >= 1f)
            {
                break;
            }

            await Task.Yield();
        }

        try
        {
            while (true)
            {
                await Task.Delay(5000, cancellationToken);
            }
        }
        catch (OperationCanceledException)
        {
            // ZAS: Perfectly normal
        }

        m_happyEmote.enabled = false;
        m_sadEmote.enabled = false;
        m_excitedEmote.enabled = false;
        m_bubble.enabled = false;
    }

}
