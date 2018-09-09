using System;
using System.Threading;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Ludwig
{
    public class Track : IDisposable
    {
        private readonly WaveOutEvent _wo;

        private readonly SignalGenerator _generator;

        private readonly FadeInOutSampleProvider _fader;

        public Track()
        {

            _generator = new SignalGenerator
            {
                Gain = .5,
                Frequency = 100,
                Type = SignalGeneratorType.Sin
                
            };

            _fader = new FadeInOutSampleProvider(_generator);

            _wo = new WaveOutEvent();
            _wo.Init(_fader);
        }

        public void Play(decimal frequency)
        {
            _generator.Frequency = (long) frequency;
            _generator.Gain = .5;
            _fader.BeginFadeOut(1000);

            if (_wo.PlaybackState != PlaybackState.Playing)
            {
                _wo.Play();
            }
        }

        public void Dispose()
        {
            _wo.Dispose();
        }
    }
}
