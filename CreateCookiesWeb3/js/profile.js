$.ajaxSetup({
    xhrFields: {
        withCredentials: true
    }
});
$.get('http://iis.infoteket.nu:8080/CreateCookiesClientProject/CustomerProfileServlet', function (data) {
    $('#mainContent').html(data);
});