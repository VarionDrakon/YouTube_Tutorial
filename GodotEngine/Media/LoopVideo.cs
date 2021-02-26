using Godot;

public class MainMenu : Node
{
	public override void _Ready()
	{

		var _VideoBackgroundMenu = GetNode<VideoPlayer>("Label/VideoPlayer");

		var _ResourceVideo = (VideoStream)ResourceLoader.Load<VideoStream>("res://Video/Snow-Fall.webm");

		_VideoBackgroundMenu.SetStream(_ResourceVideo);

	 }

	public override void _Process(float delta)
	{
		var _VideoBackgroundMenu = GetNode<VideoPlayer>("Label/VideoPlayer");

		if (_VideoBackgroundMenu.IsPlaying() == false)
		{
			_VideoBackgroundMenu.Play();

		}
	}
