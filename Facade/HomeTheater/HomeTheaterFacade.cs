using System;

namespace HomeTheater
{
	public class HomeTheaterFacade
	{
		private Amplifier _amp;
		private Tuner _tuner;
		private DvdPlayer _dvd;
		private CdPlayer _cd;
		private Projector _projector;
		private TheaterLights _lights;
		private Screen _screen;
		private PopcornPopper _popper;

		public HomeTheaterFacade(Amplifier amp, Tuner tuner, DvdPlayer dvd, CdPlayer cd, Projector projector,
			TheaterLights lights, Screen screen, PopcornPopper popper)
		{
			_amp = amp;
			_tuner = tuner;
			_dvd = dvd;
			_cd = cd;
			_projector = projector;
			_lights = lights;
			_screen = screen;
			_popper = popper;
		}

		public void WatchMovie(string movie)
		{
			Console.WriteLine("Get ready to watch a movie...");
			_popper.On();
			_popper.Pop();
			_lights.Dim(10);
			_screen.Down();
			_projector.On();
			_projector.WideScreenMode();
			_amp.On();
			_amp.SetDvd(_dvd);
			_amp.SetSurroundSound();
			_amp.SetVolume(5);
			_dvd.On();
			_dvd.Play(movie);
		}

		public void EndMovie()
		{
			Console.WriteLine("Shutting movie theater down...");
			_popper.Off();
			_lights.On();
			_screen.Up();
			_projector.Off();
			_amp.Off();
			_dvd.Stop();
			_dvd.Eject();
			_dvd.Off();
		}

		public void ListenToCd(string cdTitle)
		{
			Console.WriteLine("Get ready for an audiopile experience...");
			_lights.On();
			_amp.On();
			_amp.SetVolume(5);
			_amp.SetCd(_cd);
			_amp.SetStereoSound();
			_cd.On();
			_cd.Play(cdTitle);
		}

		public void EndCd()
		{
			Console.WriteLine("Shutting down CD...");
			_amp.Off();
			_amp.SetCd(_cd);
			_cd.Eject();
			_cd.Off();
		}

		public void ListenToRadio(double frequency)
		{
			Console.WriteLine("Tuning in the airwaves...");
			_tuner.On();
			_tuner.SetFrequency(frequency);
			_amp.On();
			_amp.SetVolume(5);
			_amp.SetTuner(_tuner);
		}

		public void EndRadio()
		{
			Console.WriteLine("Shutting down the tuner...");
			_tuner.Off();
			_amp.Off();
		}
	}
}