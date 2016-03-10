%>
String json = "{ \"title\": \"testTitle\", \"link\" : \"testLink\"}";
response.getWriter().write(json);
response.getWriter().flush();
response.getWriter().close();
<%