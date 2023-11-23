(function ($) {
    'use strict';
    var form = $('.contact-form form'),
        message = $('.messenger-box-contact__msg'),
        form_data;

    // const submit = document.getElementById("submit-form");
    // submit.addEventListener("click", validate);
    // function validate(e) {
    //     const message = document.getElementById('required-msg');

    //     const fullName = document.getElementById("full-name");
    //     const email = document.getElementById("email");
    //     const subject = document.getElementById("subject");
    //     let valid = true;

    //     if (!fullName.value || !email.value || !subject.value) {
    //         message.classList.add('show');
    //         fullName.classList.add("invalid");
    //     } else {
    //         message.classList.remove('show');
    //     }
        
    //     return valid;
    // }


    // Success function
    function done_func(response) {
        message.fadeIn().removeClass('alert-danger').addClass('alert-success');
        message.text(response);
        setTimeout(function () {
            message.fadeOut();
        }, 3000);
        form.find('input:not([type="submit"]), textarea').val('');
    }

    // fail function
    function fail_func(data) {
        message.fadeIn().removeClass('alert-success').addClass('alert-success');
        message.text(data.responseText);
        setTimeout(function () {
            message.fadeOut();
        }, 3000);
    }
    
    form.submit(function (e) {
        e.preventDefault();

        

        const fullName = document.getElementById("full-name");
        const email = document.getElementById("email");

        if (!fullName.value || !email.value) {
            fullName.classList.add("invalid");
            console.log('false');
            return false
        }

        form_data = $(this).serialize();
        $.ajax({
            type: 'POST',
            url: form.attr('action'),
            data: form_data
        })
        .done(done_func)
        .fail(fail_func);
    });
    
})(jQuery);