<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>SearchEmail</title>
</head>
<body>
	<form action="/CreateCookiesClientProject/MainServlet" method="post">

		<table cellspacing="0" cellpadding="0" border="0" align="left">
			<tr>
				<td><h2>Search email:</h2></td>
			</tr>
			<tr>
				<td><input type="text" name="txtEmail" size="25" maxlength="25"></input>
					<input type="submit" name="submit" value="Skicka fråga" /></td>
				<td></td>
			</tr>
		</table>

		<input name="operation" value="showemail" type="hidden">

	</form>


</body>
</html>