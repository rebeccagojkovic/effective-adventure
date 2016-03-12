$('#search').keyup(function () {
    "use strict";
    var searchField = $('#search').val();
    var myExp = new RegExp(searchField, 'i');
    $.getJSON('http://iis.infoteket.nu:8080/CreateCookiesClientProject/ProductTable', function (data) {
        var output = '<ul class="searchresult">';
        $.each(data, function (idx, obj) {
            $.each(obj, function (key, val) {
                if ((val.pName.search(myExp) !== -1)) {

                    output += '<div class="productRow">';
                    output += '<article class="productInfo">';
                    output += '<div><img alt="sample" src="eCommerceAssets/images/' + val.pNumber + '.jpg"></div>';
                    output += '<p class="price">20kr</p>';
                    output += '<p class="productContent">' + val.pName + '</p>';
                    output += '<input type="button" name="button" value="Köp" class="buyButton">';
                    output += '</article>';
                    output += '</div>';


                }
            });

        });

        $('#mainContent').html(output);
    });
});