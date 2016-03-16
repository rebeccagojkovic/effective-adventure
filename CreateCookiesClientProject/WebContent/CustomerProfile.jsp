<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@taglib uri="http://java.sun.com/jsp/jstl/fmt" prefix="fmt"%>
<%
	response.setHeader("Access-Control-Allow-Origin", "http://iis.infoteket.nu");
	response.setHeader("Access-Control-Allow-Credentials", "true");
%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>CustomerProfile</title>
</head>
<div id="productRow">
<div class="productRow">
	<article class="productInfo">
	<h1>Din profil</h1>
	<form
		action="http://iis.infoteket.nu:8080/CreateCookiesClientProject/CustomerProfileServlet"
		method="post">
		<fieldset>
			<legend> Företagsuppgifter </legend>

			Kundnummer: <br> <input type="text" name="cNumber"
				maxlength="20" value="${cNumber}" readonly> <br> Företagsnamn: <br>
			<input type="text" name="cName" maxlength="50" value="${cName}">
			<br>

		</fieldset>
		<fieldset>
			<legend> Adressuppgifter </legend>
			Adress: <br> <input id="first_line" type="text" name="cAddress"
				maxlength="200" value="${cAddress}"> <br> Postadress: <br>
			<input id="state" type="text" name="cPostalAddress"
				value="${cPostalAddress}"> <br>
		</fieldset>
		<fieldset>
			<legend> Land </legend>
			<input id="country" type="text" name="cCountry" maxlength="200"
				value="${cCountry}">

		</fieldset>
		<fieldset>
			<legend> Ditt konto </legend>
			Användarnamn: <br> <input type="email" name="cEmail"
				value="${cEmail}"> <br> Lösenord: <br> <input
				type="password" name="cPassword" value="${cPassword}"> <br>
			<br>
			<!-- <input type="Submit" value="Submit"> -->
		</fieldset>
		<!-- </form> -->
		<br> <input id="saveProfile" type="submit" value="Spara">
	</form>
	<a href="bestallning.html">
		<button id="goToOrder">Gå vidare till Beställning</button>

	</a> </article>
	<article class="productInfo"> <!-- Each individual product description -->
	<h1>Orderhistorik</h1>


	</article>
</div>
</div>

</body>
</html>