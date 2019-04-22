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
<title>Резултати</title>
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
<h1><img src="./Events.jpg" style="width:720px;height:480px;"></h1>
<jsp:useBean id="myRiderAllData" class="Timings.AllRiders" scope="application"/>
<table>
<thead class="ui-widget-header">
    <tr>
    <th align = "center">Брой състезатели</th>
    </tr>
  </thead>  
<tbody class="ui-widget-content">
<tr>
   <td align = "center"><%=myRiderAllData.getRidersCount()%></td>
</tr>
</tbody>
</table>
<table>
<thead class="ui-widget-header">
    <tr>
    <th align = "center">Имена</th>
    <th align = "center">Категория</th>
    <th align = "center">Години</th>
    <th align = "center">Отбор</th>
    <th align = "center">Такса</th>
    <th align = "center">Състезание</th>
    <th align = "center">Стаус на плащането</th>
    <th align = "center">Обиколки</th>   
    </tr>
  </thead>  
<tbody class="ui-widget-content">
<%=myRiderAllData.GenerateRidersReport()%>
</tbody>
</table>
</body>
</html>