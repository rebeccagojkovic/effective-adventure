$(document).ready(function() {
    $('#post').submit(function() {
        window.open('', 'formpopup', 'width=400,height=400,resizeable');
        this.target = 'formpopup';

    });
});