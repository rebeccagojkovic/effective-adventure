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
				
				<td><input type="text" name="searchCustomer" maxlength="30" /></td>
				
			</tr>
			<tr>
				<td><input type="radio" name="radiocustomersearch" id="radioCompanyName" value="companyName" maxlength="30" />Company Name</td>
				
			</tr>
			<tr>
				
				<td><input type="radio" name="radiocustomersearch" id="radioCompanyEmail" value="companyEmail" maxlength="40" />Company Email</td>
				
			</tr>
			<tr>
				<td><input type="radio" name="radiocustomersearch" id="radioCompanyCountry" value="companyCountry" maxlength="30" />Country</td>
			</tr>
			<tr>
				<td><input type="radio" name="radiocustomersearch" id="radioPostalAddress" value="postalAddress" maxlength="30" />Postal Address</td>
			</tr>
			<tr>
				<td><input type="radio" name="radiocustomersearch" id="radioCompanyAddress" value="companyAddress" maxlength="30" />Address</td>
			</tr>
			<tr>
			<td><input type="submit" name="submit" value="Send question" /></td>
			</tr>
</table>
<input name="operation" value="showcustomer" type="hidden">
</form>
</body>
</html>