<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<%@ page import="entity.ejb.Product"%>
<%@ page import="facade.FacadeLocal"%>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Show Person</title>
</head>
<body>
	<%
		Product p = (Product) request.getAttribute("product");
	%>
	<h2>Person:</h2>
	<p>
		<input type="text" name="productNumber" value="<%=p.getpNumber()%>">
	</p>
	<p>
		<input type="text" name="productName" value="<%=p.getpName()%>">
	</p>
	<p>
		<input type="text" name="productTime" value="<%=p.getpTime()%>">
	</p>
	<p><%=new java.util.Date()%></p>
	<form action="/MVCProject/MainServlet" method="post">
		<input type="submit" name="submit" value="Tillbaka"> <input
			name="operation" value="searchproduct" type="hidden">
	</form>
</body>
</html>