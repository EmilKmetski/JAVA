<%@ page language="java" 
    import="java.util.*"
    contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<script type="text/javascript" src="./jqs/jquery-2.1.4.min.js"></script>
<script type="text/javascript" src="./jqs/jquery-ui-1.11.4/jquery-ui.js"></script>
<link rel="stylesheet" href="./jqs/jquery-ui-themes-1.11.4/themes/redmond/jquery-ui.css">
<meta http-equiv="Content-Type" content="text/html;" charset="UTF-8">
<title>Въведен състезател</title>
</head>
<style>
#inputBox {
    background: #DFEFFC url(./jqs/jquery-ui-themes-1.11.4/themes/redmond/images/ui-bg_glass_85_dfeffc_1x400.png) 50% 50% repeat-x;
    color: #2E6E9E;
    font-weight: bold;
    border: 1px solid #C5DBEC;
    padding: 5px;
    border-radius: 5px;
}
#format { margin-top: 2em; }
body
{
    background-color: #d0e4fe;
}
table
{
    margin-left: auto;
	margin-right: auto;
	empty-cells: hide;
}
td
{
vertical-align: center;
horizontal-align: center;
}
h1
{
    color: orange;
    text-align: center;
}
p
{
    font-family: "Times New Roman";
    font-size: 14px;
}
</style>
<body>
<H1>Информация за въведения състезател</H1>
<jsp:useBean id="myRiderData" class="Timings.RiderData" scope="session"/>
<% response.setHeader("Refresh", "6;url=Riders.html"); %>
<%=myRiderData.getRiderAllData(true)%>

</body>
</html>