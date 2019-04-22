package Timings;

import java.io.*;

import javax.servlet.ServletContext;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.*;
import java.util.ArrayList;

@WebServlet("/FastestRider")

public class FastestRider extends HttpServlet {
	private static final long serialVersionUID = 1L;
 
	protected void doGet(HttpServletRequest request,HttpServletResponse response) throws IOException 
    {
		
		request.setCharacterEncoding("UTF-8");
		response.setCharacterEncoding("UTF-8");
		response.setContentType("text/html;");

		//присвояваме обекта от тип AllRiders като го четем от страницата (същия обект който е генериран от jsp-то)         	
		ServletContext context = getServletContext();
    	AllRiders myAllRd = (AllRiders)context.getAttribute("myRiderAllData");
    	context.setAttribute("myRiderAllData", myAllRd);    
     	
    	PrintWriter out=response.getWriter();
   	  	if(myAllRd != null)
   	  	{
	    	//извличаме всички състазатели в масив от обекти RiderData(данни за състезателя)
	    	ArrayList<RiderData> RiderList = myAllRd.getMyRidersList();
	    	
	    	int maxlaps = 0;
	    	int currentRiderID =0;
	    	int currentlaps = 0;
	    	for (int i =0; i < RiderList.size() ; i ++)
	    	{
	    		currentlaps = RiderList.get(i).getEventLaps();
	    		if(currentlaps >= maxlaps)
	    		{
	    			maxlaps = currentlaps;
	    			currentRiderID = i;
	    		}
	      	}
	    	
	    	String myFastestRider = "<H1>Имена: " + RiderList.get(currentRiderID).getRiderNames() +"</H1>" + "</br>" +"<H1>Обиколки: " + RiderList.get(currentRiderID).getEventLaps() +"</H1>";
	    	//Задаване на стринг който генерира страницата с резултата за първия състезател
	    	String myPageString = "<!DOCTYPE html><html><head><script type=\"text/javascript\" src=\"./jqs/jquery-2.1.4.min.js\"></script> <script type=\"text/javascript\" src=\"./jqs/jquery-ui-1.11.4/jquery-ui.js\"></script><link rel=\"stylesheet\" href=\"./jqs/jquery-ui-themes-1.11.4/themes/redmond/jquery-ui.css\"></head>"
	    	+"<meta http-equiv=\"Content-Type\" content=\"text/html;\" charset=\"UTF-8\">"
	    	+"<title>Печеливш състезател</title>"
	    	+"<script>"
	    	+" $(function() {"
	    	+"	$( \"#btBack\" ).button();"
	    	+"});"
	    	+"</script>"
	    	+"<style>"
	    	+"#inputBox {"
	    	+"	background: #DFEFFC url(./jqs/jquery-ui-themes-1.11.4/themes/redmond/images/ui-bg_glass_85_dfeffc_1x400.png) 50% 50% repeat-x;"
	    	+"  color: #2E6E9E;"
	    	+"  font-weight: bold;"
	    	+"  border: 1px solid #C5DBEC;"
	    	+"  padding: 5px;"
	    	+"  border-radius: 5px;"
	    	+"  }"
	    	+"#format { margin-top: 2em; }"
	    	+"body"
	    	+"{"
	    	+"    background-color: #d0e4fe;"
	    	+"}"
	    	+"table"
	    	+"{"
	    	+"  margin-left: auto;"
	    	+"	margin-right: auto;"
	    	+"	empty-cells: hide;"
	    	+"}"
	    	+"td" 
	    	+"{"
	    	+"vertical-align: center;"
	    	+"horizontal-align: center;"
	    	+"}"
	    	+"h1"
	    	+"{"
	    	+"  color: orange;"
	    	+"  text-align: center;"
	    	+"}"
	    	+"p"
	    	+"{"
	    	+"   font-family: \"Times New Roman\";"
	    	+"   font-size: 14px;"
	    	+"}"
	    	+"</style>"
	    	+"</head>"
	    	+"<body>"
	    	+"<H1>Състезател на първо място</H1>"
	    	+"<h1><img src=\"./Events.jpg\" style=\"width:720px;height:480px;\"></h1>"
	    	+"<table>"
	    	+"<tr>"
	    	+"    <td align = \"center\"><button type=\"button\" id = \"btBack\" onclick=\"window.location.href='Index.html';\">Назад</button></td>"
	    	+"   </tr>"	
	    	+"</table>"
	    	+ myFastestRider
	    	+"</body>"
	    	+"</html>";	    	
	    	out.println(myPageString);	
   	  	}
   	  	else
   	  	{
	   	 	ErrorsInfo.setErrorText("Няма въведени състезатели въведете поне един състезател");
			ErrorsInfo.setErrorScript("Servlet FastestRider");
			response.sendRedirect("./ErroIncorectData.jsp");			   	  		
   	  	}
   	  	
   	  	
    }

}
