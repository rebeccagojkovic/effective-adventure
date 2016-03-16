<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<%@ page import="entity.ejb.Order"%>
<%@ page import="facade.FacadeLocal"%>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Show order</title>
</head>
<body>

	<%
		Order o = (Order) request.getAttribute("order");
	%>

	<h2>Order:</h2>
	<p>
		<input type="text" name="radioOrderSearch" value="<%=o.getoNumber()%>">
	</p>
	<p>
		<input type="text" name="radioexpectedDeliveryDate"
			value="<%=o.getExpectedDeliveryDate()%>">
	</p>
	<p>
	<p>
		<input type="text" name="radioOrderSearch"
			value="<%=o.getisDelivered()%>">
	</p>
	<p>
	<form action="/CreateCookiesClientProject/OrderServlet" method="post">
		<input type="submit" name="submit" value="Tillbaka"> <input
			name="operation" value="SearchOrder" type="hidden">
	</form>


</body>
</html>