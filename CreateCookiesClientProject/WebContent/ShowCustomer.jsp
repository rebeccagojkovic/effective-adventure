<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ page import="entity.ejb.Customer"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">

<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Show Customer</title>
</head>
<body>
	<%
		Customer c = (Customer) request.getAttribute("customer");
	%>
	<h2>Customer:</h2>
	<p>
		<input type="text" name="companyName" value="<%=c.getcName()%>">
	</p>
	<p>
		<input type="text" name="email" value="<%=c.getcEmail()%>">
	</p>
	<p>
	<p>
		<input type="text" name="country" value="<%=c.getcCountry()%>">
	</p>
	<p>
	<p>
		<input type="text" name="postaladdress"
			value="<%=c.getcPostalAddress()%>">
	</p>

	<p>
		<input type="text" name="address" value="<%=c.getcAddress()%>">
	</p>
	<form action="/CreateCookiesClientProject/CustomerServlet"
		method="post">
		<input type="submit" name="submit" value="Tillbaka"> <input
			name="operation" value="SearchCustomer" type="hidden">
	</form>
</body>
</html>