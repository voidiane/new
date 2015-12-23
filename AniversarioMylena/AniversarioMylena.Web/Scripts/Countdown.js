var birthday;

$(function () {
    var now = new Date();

    if (now.getMonth() > 0) {
        birthday = new Date("February 08, " + (now.getFullYear() + 1) + " 00:01:00");
    } else {
        birthday = new Date("February 08, " + now.getFullYear() + " 00:01:00");
    }
    count();
});

function count() {
    var now = new Date();
    birthday = new Date();
    var timeDiff = birthday.getTime() - now.getTime();
    if (timeDiff <= 0) {
        clearTimeout(timeOut);
        $("form#formPost").submit();
    } else {
        var seconds = Math.floor(timeDiff / 1000);
        var minutes = Math.floor(seconds / 60);
        var hours = Math.floor(minutes / 60);
        var days = Math.floor(hours / 24);
        hours %= 24;
        minutes %= 60;
        seconds %= 60;

        var timer = "";
        timer += (days < 10 ? "0" + days : days) + "d";
        timer += " : " + (hours < 10 ? "0" + hours : hours) + "h";
        timer += " : " + (minutes < 10 ? "0" + minutes : minutes) + "m";
        timer += " : " + (seconds < 10 ? "0" + seconds : seconds) + "s";

        $("#timer").html(timer);
        var timeOut = setTimeout('count()', 1000);
    }
}