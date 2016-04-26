<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@page import="entity.ejb.Recipe"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">

<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">

<title>Show Recipe</title>
</head>
<body>
	<%
		Recipe r = (Recipe) request.getAttribute("recipe");
	%>
	<h2>Recipe:</h2>
	<p>
		<input type="text" name="recipeID" value="<%=r.getiNumberPNumber()%>">
	</p>

	<p>
		<input type="text" name="quantity" value="<%=r.getQuantity()%>">
	</p>

	<p>
	<form action="/CreateCookiesClientProject/RecipeServlet" method="post">
		<input type="submit" name="submit" value="Tillbaka"> <input
			name="operation" value="searchrecipe" type="hidden">
	</form>


</body>
</html>