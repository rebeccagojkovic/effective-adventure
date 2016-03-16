<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@ page import="entity.ejb.Ingredient"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">

<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Show Ingredient</title>
</head>
<body>
	<%
		Ingredient i = (Ingredient) request.getAttribute("ingredient");
	%>
	<h2>Ingredient:</h2>
	<p>
		<input type="text" name="iNumber" value="<%=i.getiNumber()%>">
	</p>
	<p>
		<input type="text" name="iName" value="<%=i.getiName()%>">
	</p>
	<p>
	<p>
		<input type="text" name="iQuantityInStock" value="<%=i.getiQuantityInStock()%>">
	</p>
	<p>
	
	<form action="/CreateCookiesClientProject/IngredientServlet"
		method="post">
		<input type="submit" name="submit" value="Tillbaka"> <input
			name="operation" value="SearchIngredient" type="hidden">
	</form>
</body>
</html>