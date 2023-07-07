using UnityEngine;
using DG.Tweening;

// Kod Tekrar�n� �nlemek i�in kullan�l�r. Ayn� zamanda geni�letilebilir metotlard�r.
public static class TweenExtension
{
    // Burada DOTween i�ine SkinnedMeshRenderer'da kullan�labilen bir extension kullan�lm��t�r.
    public static Tween DOBlendShapeWeight(this SkinnedMeshRenderer meshRenderer, int index, float endValue, float duration)
    {
        return DOTween.To(() => meshRenderer.GetBlendShapeWeight(index),
            x => meshRenderer.SetBlendShapeWeight(index, x),
            endValue, duration
            );
    }

    // Burada Tween geri d�nd�r�lmesinin sebebi DOTweenin di�er fonksiyonlar�n� kullanmak i�in yap�l�r. 
    public static Tween DOCountdown(this TMPro.TextMeshProUGUI tmp, int startValue, int endValue, float duration)
    {
        return DOVirtual.Int(startValue, endValue, duration, x => tmp.text = x.ToString());
    }

    // Burada direk DOVirtual kullan�labilirdi. Bunun yerine extension kullan�lm��t�r. 
    public static Tween DODelay(this TMPro.TextMeshProUGUI tmp, float duration, string value)
    {
        return DOVirtual.DelayedCall(duration, () => tmp.text = value);
    }

}
