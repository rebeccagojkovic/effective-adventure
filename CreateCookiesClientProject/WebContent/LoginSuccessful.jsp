<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>LoginSuccessful</title>
</head>
<body>
	<%
		String cEmail = null;
		Cookie[] cookies = request.getCookies();
		if (cookies != null) {
			for (Cookie cookie : cookies) {
				if (cookie.getName().equals("cEmail"))
					cEmail = cookie.getValue();
			}
			response.sendRedirect("http://iis.infoteket.nu/CreateCookiesWeb/index.html");
		}
		else if(cEmail == null) {

			response.sendRedirect("error.html");
		}
	%>

</body>
</html>