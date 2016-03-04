<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
	<form action="/CustomerServlet" method="post">
		<table cellspacing="0" cellpadding="0" border="0" align="left">
			<tr>
				<td><h2>Search Order:</h2></td>
			</tr>
			<tr>

				<td><input type="text" name="searchOrder" maxlength="30" /></td>

			</tr>
			<tr>
				<td><input type="radio" name="radioOrderSearch"
					id="radioOrderNumber" value="orderNumber" maxlength="30" />Order
					Number</td>

			</tr>
			<tr>

				<td><input type="radio" name="radioOrderSearch"
					id="radioexpectedDeliveryDate" value="expectedDeliveryDate"
					maxlength="20" />Expected Delivery Date</td>

			</tr>
			<tr>
				<td><input type="radio" name="radioOrderSearch"
					id="radioisDelivered" value="isDelivered" maxlength="20" />Is
					Delivered</td>
			</tr>
			<tr>
				<td><input type="submit" name="submit" value="Send question" /></td>
			</tr>
		</table>
		<input name="operation" value="showorder" type="hidden">
	</form>
</body>
</html>