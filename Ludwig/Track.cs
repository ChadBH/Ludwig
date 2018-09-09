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

        public Track()
        {

            _generator = new SignalGenerator
            {
                Gain = 0.1,
                Frequency = 100,
                Type = SignalGeneratorType.Sin
            };
            _wo = new WaveOutEvent();
            _wo.Init(_generator);
        }

        public void Play(decimal frequency)
        {
            _generator.Frequency = (long) frequency;

            if (_wo.PlaybackState != PlaybackState.Playing)
            {
                _wo.Play();
                Thread.Sleep(TimeSpan.FromMilliseconds(250));
                _wo.Pause();
            }
        }

        public void Dispose()
        {
            _wo.Dispose();
        }
    }
}
