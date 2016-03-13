<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@taglib uri="http://java.sun.com/jsp/jstl/fmt" prefix="fmt"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>CustomerProfile</title>
</head>
<body>
	<table>
		<tr>
			<td>Företag <input class="registerTable" name="cName"
				value="${cName}">
			</td>
		</tr>
		<tr>
			<td>Address <input class="registerTable" name="cAddress"
				value="${cAddress}">
			</td>
		</tr>
		<tr>
			<td>Postadress <input class="registerTable"
				name="cPostalAddress" value="${cPostalAddress}">
			</td>
		</tr>
		<tr>
			<td>Land <input class="registerTable" name="cCountry"
				value="${cCountry}">
			</td>
		</tr>
		<tr>
			<td>Email <input class="registerTable" name="cEmail"
				value="${cEmail}">
			</td>
		</tr>

		<tr>
			<td>Lösenord <input class="registerTable" name="cPassword"
				value="${cPassword}">
			</td>
		</tr>

		<tr>
			<td><input class="buttonLoggainRegistrera" type="submit"
				value="Registrera"></td>
		</tr>
	</table>
</body>
</html>