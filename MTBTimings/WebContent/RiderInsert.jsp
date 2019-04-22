<%@page language="java" 
contentType="text/html;charset=UTF-8" 
pageEncoding="UTF-8" 
%>
<%@page import="Timings.RiderData"%>
<%@page import="Timings.ErrorsInfo"%>
<%@page import="java.text.DateFormat"%>
<%@page import="java.text.SimpleDateFormat"%>
<%@page import="java.util.Date"%>
<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html;" charset="UTF-8" >
</head>
<body>
<jsp:useBean id="myRiderData" class="Timings.RiderData"  scope="session"/>
<jsp:useBean id="myRiderDataInput" class="Timings.RiderData"/>
<jsp:useBean id="myRiderAllData" class="Timings.AllRiders" scope="application"/>
<% 	
	//задаваме енкодинга да е utf-8 за да нямамаме проблеми с преобразуването и четенето на стрингове
	request.setCharacterEncoding("UTF-8");	
	//прочитаме променливите	
	String eventName = request.getParameter("eventName");
    String ridersNames = request.getParameter("rnames");	
    String category = request.getParameter("category");
    String Age = request.getParameter("Age");
    String team = request.getParameter("team");
    String taxvalue = request.getParameter("taxvalue");
    String Laps = request.getParameter("Laps");   
    String teamа = request.getCharacterEncoding();
      
	int myAge = Integer.parseInt(Age);
	int myCategoryAge = Integer.parseInt(category);
	int myLaps = Integer.parseInt(Laps);
	float myTax = Float.parseFloat(taxvalue);
	boolean myPayment = true;
	boolean ageCheck = false;
	String myCategory = "";
	
    //Проверяваме дали има плащане на такса или не
    if(request.getParameter("payment")!= null)
    {
    	myPayment = true;
    }
    else
    {
    	myPayment = false;
    }
		//Логика която проверява дали зададените години отговарят на избраната категория на състезателя.
		switch (myCategoryAge)
		{
		case 15:
			if (myAge < 15)
			{	
				myCategory = "До 15г.";
				ageCheck = true;
			}
		break;
		case 18 :
			if ((myAge >= 15) && (myAge < 18))
			{	
				myCategory = "от 15г. До 18г.";
				ageCheck = true;
			}			
		break;
		case 30:
			if ((myAge >= 18) && (myAge <=35)) 
			{	
				myCategory = "от 18 до 35г.";
				ageCheck = true;
			}
		break;
		}
		//ако логиката за проверка на години и категория ни върне лъжа тогва показваме прозореца за грешка като задаваме и грешките
		//в противен случай въвеждаме данните за състезателя
		if(ageCheck == false)
		{
			ErrorsInfo.setErrorText("Избрана е нe правилна категория за състезателя!<br>Не отговаря на въведените години!");
			ErrorsInfo.setErrorScript("RiderInsert.jsp");
			response.sendRedirect("./ErroIncorectData.jsp");		
		}
		else
		{				
			//Задавме параметрите на Състезателя за да го покажем на страницата за въвеждане на състезатели
			myRiderData.setEventName(eventName);
			myRiderData.setEventCategory(myCategory);
			myRiderData.setEventTax(myTax);
			myRiderData.setPaymentStatus(myPayment);
			myRiderData.setRiderAge(myAge);
			myRiderData.setRiderNames(ridersNames);
			myRiderData.setRiderTeam(team);
			myRiderData.setEventLaps(myLaps);
			
			//Задавме параметрите на Състезателя и го добавяме в листа състезатели
			myRiderDataInput.setEventName(eventName);
			myRiderDataInput.setEventCategory(myCategory);
			myRiderDataInput.setEventTax(myTax);
			myRiderDataInput.setPaymentStatus(myPayment);
			myRiderDataInput.setRiderAge(myAge);
			myRiderDataInput.setRiderNames(ridersNames);
			myRiderDataInput.setRiderTeam(team);
			myRiderDataInput.setEventLaps(myLaps);
						
			//Добавяме състезаятел в класа който запазва всички състезатели
			myRiderAllData.AddMyRider(myRiderDataInput);
			//Показва страница за текущо въведения състезател
			response.sendRedirect("./RiderInputResult.jsp");		
	
		}
%>
</body>
</html>