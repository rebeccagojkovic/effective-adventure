<%@ taglib prefix="json" uri="http://www.atg.com/taglibs/json" %>

<json:object>
    <json:array name="products" var="product" items="${products.lineProducts}">
    <json:object>
      <json:property name="pName" value="${product.pName}"/>
      <json:property name="price" value="${product.price}"/>      
    </json:object>
  </json:array>
</json:object>

<%
   response.setHeader("Access-Control-Allow-Origin", "http://iis.infoteket.nu");
   response.setContentType("application/json");
%>