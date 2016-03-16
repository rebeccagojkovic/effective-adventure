<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Search Ingredient</title>
</head>
<body>
	<form action="/CreateCookiesClientProject/IngredientServlet" method="post">
		<table cellspacing="0" cellpadding="0" border="0" align="left">
			<tr>
				<td><h2>Search Ingredient:</h2></td>
			</tr>
			<tr>

				<td><input type="text" name="searchIngredient" maxlength="30" /></td>

			</tr>
			<tr>
				<td><input type="radio" name="radioIngredientSearch"
					id="radioIngredientName" value="iNumber" maxlength="30" />Ingredient
					Number</td>

			</tr>
			<tr>

				<td><input type="radio" name="radioIngredientSearch"
					id="radioIngredientNumber" value="iName" maxlength="10" />Ingredient 
					Name</td>

			</tr>
			<tr>
				<td><input type="radio" name="radioIngredientSearch"
					id="radioIngredientQuantityInStock" value="iQuantityInStock" maxlength="30" />Quantity in stock</td>
			</tr>
			<tr>
				<td><input type="submit" name="submit" value="Send question" /></td>
			</tr>
		</table>
		<input name="operation" value="showingredient" type="hidden">
	</form>
</body>
</html>