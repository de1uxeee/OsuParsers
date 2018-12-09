using OsuParsers.Enums;
using System.Drawing;

namespace OsuParsers.Beatmaps.Objects.Catch
{
    public class CatchHitCircle : CatchHitObject
    {
        public CatchHitCircle(Point position, int startTime, int endTime, HitSoundType hitSound, bool isNewCombo, int comboOffset, HitObjectExtras extras)
            : base(position, startTime, endTime, hitSound, isNewCombo, comboOffset, extras)
        {
        }
    }
}
