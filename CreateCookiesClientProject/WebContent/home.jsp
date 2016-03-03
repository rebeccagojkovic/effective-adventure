<%@page import="java.util.List"%>
<%@page import="entityAccess.eao.CustomerEAOImpl"%>
<%@page import="java.util.Date"%>
<%@page import="entity.ejb.Customer"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<link rel="stylesheet" type="text/css" href="css/style.css" />
<title>Result Page</title>
</head>
<body>
	<center>
		<div id="container">
			<h1>Result Page</h1>
			<b>This is Sample Result Page</b><br />
			<%=new Date()%></br>
			<%
				Customer customer = (Customer)session.getAttribute("user");
			%>
			<b>Welcome <%=customer.getcName()%></b> <br />
			<a href="logout.jsp">Logout</a>
			</p>

			<table>
				<thead>
					<tr>
						<th>User ID</th>
						<th>First Name</th>
						<th>Middle Name</th>
						<th>Last Name</th>
						<th>email</th>
					</tr>
				</thead>
				<tbody>
					<%
						CustomerEAOImpl loginService = new CustomerEAOImpl();
						List<Customer> list = loginService.findAllCustomers();
						for (Customer c : list) {
					%>
					<tr>
						<td><%=c.getcName()%></td>
					</tr>
					<%
						}
					%>
				
				<tbody>
			</table>
			<br />
		</div>
	</center>
</body>
</html>