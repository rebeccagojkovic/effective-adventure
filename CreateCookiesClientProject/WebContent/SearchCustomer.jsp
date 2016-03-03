<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Search Customer</title>
</head>
<body>
<form action="/CustomerServlet"  method="post">
<table  cellspacing="0" cellpadding="0" border="0" align="left">
<tr>
<td><h2>Search Customer:</h2></td>
</tr>
			<tr>
				<td>Company name</td>
				<td><input type="text" name="companyName" maxlength="30" /></td>
				<td><input type="submit" name="submit" value="Send question" /></td>
			</tr>
			<tr>
				<td>Email</td>
				<td><input type="text" name="email" maxlength="40" /></td>
				<td><input type="submit" name="submit" value="Send question" /></td>
			</tr>
			<tr>
				<td>Country</td>
				<td><input type="text" name="country" maxlength="30" /></td>
				<td><input type="submit" name="submit" value="Send question" /></td>
			</tr>
			<tr>
				<td>Postal address</td>
				<td><input type="text" name="postalAddress" maxlength="100" /></td>
				<td><input type="submit" name="submit" value="Send question" /></td>
			</tr>
			<tr>
				<td>Address</td>
				<td><input type="text" name="address" maxlength="100" /></td>
				<td><input type="submit" name="submit" value="Send question" /></td>
			</tr>
</table>
<input name="operation" value="ShowCustomer" type="hidden">
</form>
</body>
</html>