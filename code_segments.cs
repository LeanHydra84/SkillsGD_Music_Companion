using System.Collections.Generic;
using System;
using System.Media;
using WMPLib;

public class MusicHandler
{
	string path;
	Button pausePlay;
	Button selMusic;
	WindowsMediaPlayer player;
	
	public MusicHandler()
	{
		path = "";
		pausePlay = new Button();
		pausePlay.Enabled = false;
		selMusic = new Button();
		player = new WindowsMediaPlayer();
		player.uiMode = "invisible";
		
	}
	
	void Main(string[] args) 
	{
		
	}

	private void selMusic_Click(object sender, EventArgs e) { UploadFile(); }

	private void pausePlay_Click(object sender, EventArgs e) 
	{
		//if player is playing, pause it. Else, play it.
	}
	
	public void UploadFile() 
	{
		OpenFileDialog file = new OpenFileDialog();
		file.Filter = "Audio Files(*.MP3; *.WAV)|*.MP3;*.WAV";
		file.Multiselect = false;
		if(file.ShowDialog() == DialogResult.OK)
		{
			player.URL = dialog.FileName;
			
			pausePlay.Enabled = true;
		}
	}

}
