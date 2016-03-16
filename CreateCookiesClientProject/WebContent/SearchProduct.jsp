<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
	<form action="/CreateCookiesClientProject/ProductServlet" method="post">
		<table cellspacing="0" cellpadding="0" border="0" align="left">
			<tr>
				<td><h2>Search Product:</h2></td>
			</tr>
			<tr>

				<td><input type="text" name="searchProduct" maxlength="30" /></td>

			</tr>
			<tr>
				<td><input type="radio" name="radioproductsearch"
					id="radioProductName" value="productName" maxlength="30" />Product
					Name</td>

			</tr>
			<tr>
				<td><input type="radio" name="radioproductsearch"
					id="radioProductNumber" value="productNumber" maxlength="30" />Product
					Name</td>

			</tr>
			<tr>

				<td><input type="radio" name="radioproductsearch"
					id="radioProductTime" value="productTime" maxlength="20" />Product
					Time</td>

			</tr>
			<tr>
				<td><input type="radio" name="radioproductsearch"
					id="radioProductPrice" value="productPrice" maxlength="30" />Product
					Name</td>

			</tr>
			<tr>
				<td><input type="submit" name="submit" value="Send question" /></td>
			</tr>
		</table>
		<input name="operation" value="showproduct" type="hidden">
	</form>
</body>
</html>