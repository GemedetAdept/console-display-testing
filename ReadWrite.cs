namespace readwrite {
public class TextFile {
	string textContent = "";
	
	public string ReadAll(string filepath) {
		string content = System.IO.File.ReadAllText(filepath);
		textContent = content;
		return content;
	}
}
}