$(document).ready(function() {
    $('.post').submit(function() {
        window.open('', 'formpopup', 'width=400,height=400,top=100, left=100');
        this.target = 'formpopup';

    });
});