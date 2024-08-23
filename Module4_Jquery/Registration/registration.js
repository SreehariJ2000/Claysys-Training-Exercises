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





$(document).ready(function() {

    FloatingLabel();
          
// First Name Validation

    $('#firstName').on('input', function() {
        const firstName = $(this).val().trim();
        const firstNameError = $('#firstNameError');

        if (firstName === '') {
            firstNameError.text("First name cannot be empty");
        } else if (!/^[a-zA-Z\s]+$/.test(firstName)) {
            firstNameError.text("Enter a valid first name");
        } else {
            firstNameError.text('');
        }
    });


// Last Name Validation

    $('#lastName').on('input', function() {
        const lastName = $(this).val().trim();
        const lastNameError = $('#lastNameError');

        if (lastName === '') {
            lastNameError.text("Last name cannot be empty");
        } else if (!/^[a-zA-Z\s]+$/.test(lastName)) {
            lastNameError.text("Enter a valid last name");
        } else {
            lastNameError.text('');
        }
    });

// Phone Number Validation

    $('#phone').on('input', function() {
        const phone = $(this).val().trim();
        const phoneError = $('#phoneError');
        const phonePattern = /^(?:\+91\s?)?[6-9]\d{9}$/;


        if (phone === '') {
            phoneError.text("Phone number cannot be empty");
        } else if (!phonePattern.test(phone)) {
            phoneError.text("Enter a valid phone number");
        } else {
            phoneError.text('');
        }
    });


// Email Validation

    $('#email').on('input', function() {
        const email = $(this).val().trim();
        const emailError = $('#emailError');
        const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

        if (email === '') {
            emailError.text("Email cannot be empty");
        } else if (!emailPattern.test(email)) {
            emailError.text("Enter a valid email");
        } else {
            emailError.text('');
        }
    });


// Address Validation

    $('#address').on('input', function() {
        const address = $(this).val().trim();
        const addressError = $('#addressError');
        const addressPattern = /^(?!^\d+$)[a-zA-Z0-9\s,'-]+$/;

        if (address === '') {
            addressError.text("Address cannot be empty");
        } else if (!addressPattern.test(address)) {
            addressError.text("Enter a valid address");
        } else {
            addressError.text('');
        }
    });

// Username Validation

$('#username').on('input', function() {
    const username = $(this).val().trim();
    const usernameError = $('#usernameError');
    const usernamePattern = /^[A-Za-z][A-Za-z0-9_]*$/; 

    if (username === '') {
        usernameError.text("Username cannot be empty");
    } else if (username.length < 5) {
        usernameError.text("Username must be at least 5 characters long");
    } else if (!usernamePattern.test(username)) {
        usernameError.text("Username can only contain letters, digits");
    } else {
        usernameError.text('');
    }
});


// Password Validation

$('#password').on('input', function() {
    const password = $(this).val().trim();
    const passwordError = $('#passwordError');
    const passwordPattern = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$/; 

    if (password === '') {
        passwordError.text("Password cannot be empty");
    }  else if (!passwordPattern.test(password)) {
        passwordError.text("Password must contain atleast one number, one uppercase and lowercase letter and minimunlength 7");
    } else {
        passwordError.text('');
    }
});

// Confirm Password Validation

    $('#confirmPassword').on('input', function() {
        const confirmPassword = $(this).val().trim();
        const password = $('#password').val().trim();
        const confirmPasswordError = $('#confirmPasswordError');

        if (confirmPassword === '') {
            confirmPasswordError.text("Confirm password cannot be empty");
        } else if (confirmPassword !== password) {
            confirmPasswordError.text("Passwords do not match");
        } else {
            confirmPasswordError.text('');
        }
    });

    $('#dob').on('change', function() {
        validateDOB();
    });

    //final submit
    $('#registrationForm').on('submit', function(event) {
        let isValid = true;

        $('input').each(function() {
            const input = $(this).val().trim();
            if (input === '') {
                isValid = false;
            }
        });

        if (!isValid) {
            event.preventDefault();
            $('#submit-error').text("You need to fill all the fields")
            console.log("cannot submit form")
        }
    });



    //future date disable
           var todayDate = new Date();
        var month = todayDate.getMonth() + 1;
        var year = todayDate.getFullYear();
        var tdate = todayDate.getDate();

        if (month < 10) {
            month = "0" + month;
        }
        if (tdate < 10) {
            tdate = "0" + tdate;
        }

        var maxDate = year + "-" + month + "-" + tdate;
        $('#dob').attr('max', maxDate);

});



function validateDOB() {
    const dob = $('#dob').val().trim();
    const dobError = $('#dobError');
    const today = new Date();
    const dobDate = new Date(dob);
    const age = today.getFullYear() - dobDate.getFullYear();

    if (dob === '') {
        dobError.text("Date of birth cannot be empty");
        return false;
    } else if (age < 18 ) {
        dobError.text("You must be at least 18 years old");
        return false;
    } else {
        dobError.text('');
        return true;
    }
}

