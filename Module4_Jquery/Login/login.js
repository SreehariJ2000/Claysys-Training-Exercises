function FloatingLabel() {
    var Parent = $('.form-group'); 

    Parent.each(function() {
        var elements = $(this),
            input = elements.find('.floating-input'); 
        
        input.on('focus', function() {
            elements.addClass('label-up focus'); 
        });
        
        input.on('blur', function() {
            elements.removeClass('focus'); 
            if (!$(this).val()) {
                elements.removeClass('label-up'); 
            }
        });
        
        input.on('change', function() {
            if ($(this).val()) {
                elements.addClass('label-up'); 
            }
        });
        
    });
}


function validateEmail() {
    var email = $('#email').val();
    var emailError = $('.email-error');
    var emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    
    if (!email) {
        emailError.text('Email cannot be empty.');
    } else if (!emailPattern.test(email)) {
        emailError.text('Please enter a valid email address.');
    } else {
        emailError.text('');
    }
}

function validatePassword() {
    var password = $('#password').val().trim();
    var passwordError = $('.password-error');
    const passwordPattern = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$/; 

    if (!password) {
        passwordError.text('Password cannot be empty.');
    } else if (!passwordPattern.test(password)) {
        passwordError.text("Password must contain atleast one number, one uppercase and lowercase letter and minimunlength 7");
    } else {
        passwordError.text('');
    }
}

function ValidateForm() {
    $('#email').on('input', validateEmail);
    $('#password').on('input', validatePassword);
}

$(document).ready(function() {

    FloatingLabel();
    ValidateForm();

    $('#loginForm').on('submit', function(event) {
        let isValid = true;

        $('input').each(function() {
            const input = $(this).val().trim();
            if (input === '') {
                isValid = false;
            }
        });

        if (!isValid) {
            event.preventDefault();
            $('.submit-error').text("You must need to fill all fields");
            console.log("cannot submit form")
        }
    });

});
