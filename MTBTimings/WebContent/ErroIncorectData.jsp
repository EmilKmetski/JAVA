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
<title>Възникна грешка</title>
<script>
  $(function() {
    $( "input[type=submit], a, button" )
      .button()
      .click(function( event ) {window.open ('./Riders.html','_self',false);      
      });
  });
  </script>
</head>
<style>
body
{
    background-color: #d0e4fe;
}
h1 
{
    color: Blue;
    text-align: center;
}
p 
{
    font-family: "Times New Roman";
    font-size: 14px;
    color: white;
}
</style>
<body>
<H1><%=new Date()%></H1>
<jsp:useBean id="myError" class="Timings.ErrorsInfo"/>
<H1><%=myError.getAllData() %></H1>
<jsp:include page="./ErrorSign.html" flush = "true" />
<H1><button id="back" >Назад</button></H1>
</body>
</html>