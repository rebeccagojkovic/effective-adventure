<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@page import="java.sql.ResultSetMetaData"%>
<%@page import="java.sql.ResultSet"%>
<%@page import="entity.ejb.Product"%>
<%@page import="facade.FacadeLocal"%>
<%@page import="entityAccess.eao.ProductEAOImpl"%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@taglib uri="http://java.sun.com/jsp/jstl/fmt" prefix="fmt"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>Insert title here</title>
</head>
<body>
	<%
		Product p = (Product) request.getAttribute("product");
	%>

<body>
	<table>
		<c:forEach items="${product}" var="product">
			<tr>
				<td>${product.id}</td>
				<td><c:out value="${product.pNumber}" /></td>
				<td><c:out value="${product.pName}" /></td>
			</tr>
		</c:forEach>
	</table>
</body>
</html>