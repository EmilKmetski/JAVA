package Timings;

public class ErrorsInfo 
{
	private static String errorText = "No Error";
	private static String errorScript = "No Script" ;
	
	public String getErrorText() {
		return errorText;
	}
	public static void setErrorText(String errorText) {
		ErrorsInfo.errorText = errorText;
	}
	public String getErrorScript() {
		return errorScript;
	}
	public static void  setErrorScript(String errorScript) {
		ErrorsInfo.errorScript = errorScript;
	}
	public String getAllData()
	{
		//Разпечатваме грешката  и скрипта или страницата на която са възникнали
		return "Error Srctipt/page: " + errorScript
			   +"<br>"+
			   "Error Text: " + errorText
				+"<br>";
	}
}
