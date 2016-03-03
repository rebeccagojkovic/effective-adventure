<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<form action="/RecipeServlet"  method="post">
<table  cellspacing="0" cellpadding="0" border="0" align="left">
<tr>
<td><h2>Search Recipe:</h2></td>
</tr>
<body>
            <tr>
				<td>Ingredient Number</td>
				<td><input type="text" name="ingredientNumber" maxlength="30" /></td>
				<td><input type="submit" name="submit" value="Send question" /></td>
			</tr>
			<tr>
				<td>Product Number</td>
				<td><input type="text" name="productNumber" maxlength="30" /></td>
				<td><input type="submit" name="submit" value="Send question" /></td>
			</tr>

</table>
<input name="operation" value="ShowCustomer" type="hidden">
</form>
</body>
</html>