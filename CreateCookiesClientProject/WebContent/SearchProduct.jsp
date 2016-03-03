<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
<form action="/ProductServlet"  method="post">
<table  cellspacing="0" cellpadding="0" border="0" align="left">
<td><h2>Search Product:</h2></td>
</tr>
			<tr>
				<td>Product Number</td>
				<td><input type="text" name="productNumber" maxlength="30" /></td>
				<td><input type="submit" name="submit" value="Send question" /></td>
			</tr>
			<tr>
				<td>Product Name</td>
				<td><input type="text" name="productName" maxlength="30" /></td>
				<td><input type="submit" name="submit" value="Send question" /></td>
			</tr>
			<tr>
				<td>Product Time</td>
				<td><input type="text" name="productTime" maxlength="30" /></td>
				<td><input type="submit" name="submit" value="Send question" /></td>
			</tr>
			
			
    </table>
		<input name="operation" value="ShowProduct" type="hidden">
</form>
</body>
</html>