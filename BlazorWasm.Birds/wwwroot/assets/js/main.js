//;(function($) {

//    $(document).ready( function() {
//        $(document).on('click', '.header-area .show-menu', function() {
//            $(this).toggleClass('active');
//            $(".header-area .navbar").toggleClass('active');
//        });
//        // $(document).on('click', '.header-area .navbar .close-menu', function() {
//        //     $(".header-area .navbar").removeClass('active');
//        // });

//        AOS.init({
//            duration: 1500,
//            once: true,
//        })
//    });

//})(jQuery);

window.loadForm = function () {
    //var div = document.createElement("div");
    //div.id = "preloader",
    //    div.className = "preloader",
    //    div.innerHTML = '<div class="black_wall"></div><div class="loader"></div>',
    //    document.body.insertBefore(div, document.body.firstChild), window.onload = function () {
    //        document.getElementById("preloader").classList.add("off")
    //    };

    $(document).on('click', '.header-area .show-menu', function () {
        $(this).toggleClass('active');
        $(".header-area .navbar").toggleClass('active');
    });
    $(document).on('click', '.header-area .navbar .close-menu', function () {
        $(".header-area .navbar").removeClass('active');
    });

    AOS.init({
        duration: 1500,
        once: true,
    })
}