// Variable Declaration
		var FullScreen = GetNode<Button>("EN/FullScreen");
//Main code start
		var Settings_JSON = new Godot.File();
		Settings_JSON.Open("res://JSONFileLangue/Settings.json", File.ModeFlags.Read);
		string dataText = Settings_JSON.GetAsText();
		JSONParseResult result = JSON.Parse(dataText);
		Godot.Collections.Dictionary Settings_JSON_Scenes = result.Result as Godot.Collections.Dictionary;
//The main code is the end, then the method of application with the exception of this code
		try
		{
			string JSONLoadDbug = Settings_JSON_Scenes["Debug"] as string;

			string JSONLoadBackFullScreen = Settings_JSON_Scenes["JSONLoadBackFullScreen"] as string;

			GD.Print($"Debug {JSONLoadDbug}");

			FullScreen.Text = $"{JSONLoadBackFullScreen}";
		}
		catch
		{
			GD.Print("Error JSON File!");
		}
