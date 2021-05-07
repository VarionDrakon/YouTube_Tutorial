// Variable Declaration
		var FileTextDebug = new Godot.File();
//Main code start
			FileTextDebug.Open("TextParser/names.txt", File.ModeFlags.Read);
			string DeugText = FileTextDebug.GetAsText();
			FileTextDebug.Close();
			GD.Print("Debug:" + DebugText);
// Main code end and start of the application method
.Connect("pressed", this, nameof(BackMenu));
