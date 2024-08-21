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
    var password = $('#password').val();
    var passwordError = $('.password-error');

    if (!password) {
        passwordError.text('Password cannot be empty.');
    } else if (password.length < 6) {
        passwordError.text('Password must be at least 6 characters long.');
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

});
