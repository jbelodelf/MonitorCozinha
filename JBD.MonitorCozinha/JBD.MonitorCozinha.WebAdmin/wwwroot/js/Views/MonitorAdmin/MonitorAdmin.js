$(document).ready(function () {
    var altura = window.screen.availHeight;
    $("#divFazer").css('height', (altura - 230));

    $("html, body").animate({ scrollTop: $(document).height() - $(window).height() }, 5000);
    window.setTimeout(function () {
        window.location.href = "/Monitor/Index";
    }, 15000);
    $("html, body").animate({ scrollTop: $("#divTop").scrollTop() }, 5000);
})