using OsuParsers.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace OsuParsers.Beatmaps.Objects.Standard
{
    public class StandardSlider : StandardHitObject
    {
        public CurveType CurveType { get; }
        public List<Point> SliderPoints { get; } = new List<Point>();
        public int Repeats { get; }
        public float PixelLength { get; }
        public HitSoundType[] EdgeHitSounds { get; }
        public Tuple<SampleSet, SampleSet>[] EdgeAdditions { get; }

        public StandardSlider(Point position, int startTime, int endTime, HitSoundType hitSound, bool isNewCombo, int comboOffset, CurveType type,
            List<Point> points, int repeats, float pixelLength, HitSoundType[] edgeHitSounds, Tuple<SampleSet, SampleSet>[] edgeAdditions, HitObjectExtras extras) 
            : base(position, startTime, endTime, hitSound, isNewCombo, comboOffset, extras)
        {
            CurveType = type;
            SliderPoints = points;
            Repeats = repeats;
            PixelLength = pixelLength;
            EdgeHitSounds = edgeHitSounds;
            EdgeAdditions = edgeAdditions;
        }
    }
}
