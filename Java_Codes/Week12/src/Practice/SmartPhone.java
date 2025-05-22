package Practice;

public class SmartPhone {
	Earphone earphone;
	
	public void musicOn(Earphone ep) {
		ep.play();
	}
	public void musicOff(Earphone ep) {
		ep.stop();
	}
}
