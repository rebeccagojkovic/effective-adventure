    $.get('http://iis.infoteket.nu:8080/CreateCookiesClientProject/RegisterServlet', function (data) {
        alert(data);
    });
    $('#mainContent').text(data);