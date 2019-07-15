
$(document).ready(function () {
    $('#location').on('change', function () {
        if (this.value == '0') {
            $(".1").show();
            $(".2").show();
            $(".3").show();
            $(".4").show();
            $(".5").show();
            $(".6").show();
        }

        if (this.value == '1') {
            $(".1").show();
            $(".2").hide();
            $(".3").hide();
            $(".4").hide();
            $(".5").hide();
            $(".6").hide();
        }

        if (this.value == '2') {
            $(".1").hide();
            $(".2").show();
            $(".3").hide();
            $(".4").hide();
            $(".5").hide();
            $(".6").hide();
        }

        if (this.value == '3') {
            $(".1").hide();
            $(".2").hide();
            $(".3").show();
            $(".4").hide();
            $(".5").hide();
            $(".6").hide();
        }

        if (this.value == '4') {
            $(".1").hide();
            $(".2").hide();
            $(".3").hide();
            $(".4").show();
            $(".5").hide();
            $(".6").hide();
        }

        if (this.value == '5') {
            $(".1").hide();
            $(".2").hide();
            $(".3").hide();
            $(".4").hide();
            $(".5").show();
            $(".6").hide();
        }

        if (this.value == '6') {
            $(".1").hide();
            $(".2").hide();
            $(".3").hide();
            $(".4").hide();
            $(".5").hide();
            $(".6").show();
        }
    });
});
