using UnityEngine;
using DG.Tweening;

// Kod Tekrarını önlemek için kullanılır. Aynı zamanda genişletilebilir metotlardır.
public static class TweenExtension
{
    // Burada DOTween içine SkinnedMeshRenderer'da kullanılabilen bir extension kullanılmıştır.
    public static Tween DOBlendShapeWeight(this SkinnedMeshRenderer meshRenderer, int index, float endValue, float duration)
    {
        return DOTween.To(() => meshRenderer.GetBlendShapeWeight(index),
            x => meshRenderer.SetBlendShapeWeight(index, x),
            endValue, duration
            );
    }

    // Burada Tween geri döndürülmesinin sebebi DOTweenin diğer fonksiyonlarını kullanmak için yapılır. 
    public static Tween DOCountdown(this TMPro.TextMeshProUGUI tmp, int startValue, int endValue, float duration)
    {
        return DOVirtual.Int(startValue, endValue, duration, x => tmp.text = x.ToString());
    }

    // Burada direk DOVirtual kullanılabilirdi. Bunun yerine extension kullanılmıştır. 
    public static Tween DODelay(this TMPro.TextMeshProUGUI tmp, float duration, string value)
    {
        return DOVirtual.DelayedCall(duration, () => tmp.text = value);
    }

}
