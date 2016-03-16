<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<%@ page import="entity.ejb.Product"%>
<%@ page import="facade.FacadeLocal"%>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Show Person</title>
</head>
<body>
	<%
		Product p = (Product) request.getAttribute("product");
	%>
	<h2>Product:</h2>
	<p>
		<input type="text" name="productNumber" value="<%=p.getpNumber()%>">
	</p>
	<p>
		<input type="text" name="productName" value="<%=p.getpName()%>">
	</p>
	<p>
		<input type="text" name="productTime" value="<%=p.getpTime()%>">
	</p>
	<form action="/CreateCookiesClientProject/ProductServlet" method="post">
		<input type="submit" name="submit" value="Tillbaka"> <input
			name="operation" value="searchproduct" type="hidden">
	</form>
</body>
</html>