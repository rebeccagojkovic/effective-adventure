$('#search').keyup(function () {
    var searchField = $('#search').val();
    var myExp = new RegExp(searchField, 'i');
    $.getJSON('json/data.json', function (data) {
        var output = '<ul class="searchresult">';
        $.each(data, function (key, val) {
            if ((val.name.search(myExp) !== -1) || (val.bio.search(myExp) !== -1)) {
                output += '<li>';
                output += '<h2>' + val.name + '</h2>';
                output += '<p>' + val.bio + '</p>';
                output += '</li>';
            }
        });
        output += '</ul>';
        $('#mainContent').html(output);
    });
});