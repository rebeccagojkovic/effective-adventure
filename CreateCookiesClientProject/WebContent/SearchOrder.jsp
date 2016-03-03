<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
<form action="/CustomerServlet"  method="post">
<table  cellspacing="0" cellpadding="0" border="0" align="left">
<tr>
<td><h2>Search Order:</h2></td>
</tr>
			<tr>
				<td>Order number</td>
				<td><input type="text" name="orderNumber" maxlength="30" /></td>
				<td><input type="submit" name="submit" value="Send question" /></td>
			</tr>
			<tr>
				<td>Expected delivery date</td>
				<td><input type="text" name="expectedDeliveryDate" maxlength="40" /></td>
				<td><input type="submit" name="submit" value="Send question" /></td>
			</tr>
			<tr>
				<td>is Delivered</td>
				<td><input type="text" name="isDelivered" maxlength="30" /></td>
				<td><input type="submit" name="submit" value="Send question" /></td>
			</tr>
</table>
<input name="operation" value="ShowOrder" type="hidden">
</form>

</body>
</html>