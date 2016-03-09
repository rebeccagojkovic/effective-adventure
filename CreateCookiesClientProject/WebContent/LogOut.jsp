<%

session.invalidate();

Cookie killMyCookie = new Cookie("mycookie", null);
killMyCookie.setMaxAge(0);
killMyCookie.setPath("/");
response.addCookie(killMyCookie);

response.sendRedirect("http://iis.infoteket.nu/CreateCookiesWeb4/index.html");


%>